import java.util.ArrayList;
import java.time.LocalDate;

public class IteratorPattern {
    public static abstract class WorkTask{
        String title;
        int priority;
        public WorkTask(String title, int priority){
            this.title = title;
            this.priority = priority;
        }
        public String getTitle(){
            return title;
        }
        public int getPriority(){
            return priority;
        }
        public int compareTo(WorkTask b){
            final int bPriority = b.getPriority();
            if(priority == bPriority){
                return 0;
            }else if(this.getPriority() > bPriority){
                return 1;
            }else{
                return -1;
            }
        }
        public abstract void show();
    }
    public static class Housework extends WorkTask{
        
        public Housework(String title, int priority){
            super(title, priority);
        }
        public void show(){
            System.out.println("Housework:[" + getPriority() + "]" + getTitle());
        }      
    }
    public static class Homework extends WorkTask{
        String title;
        int priority;
        LocalDate dueDate;
        public Homework(String title, int priority, LocalDate dueDate){
            super(title, priority);
            this.dueDate = dueDate;
        }
        public LocalDate getLocalDate(){
            return dueDate;
        }
        public void show(){
            String date = dueDate.getDayOfWeek() + " " + dueDate.getDayOfMonth() + " " + dueDate.getMonth() + " " + dueDate.getYear();
            System.out.print("Housework:[" + getPriority() + "]" + getTitle());
            System.out.println(" due date " + date);
        }
    }
    public static class WorkOut extends WorkTask{
        String title;
        int priority;
        int timeMin;
        public WorkOut(String title, int priority, int timeMin){
            super(title, priority);
            this.timeMin = timeMin;
        }
        public int getTimeMin(){
            return timeMin;
        }
        public void show(){
            System.out.print("Housework:[" + getPriority() + "]" + getTitle());
            System.out.println(" " + timeMin + " min");
        }
    }

    public static interface WorkTaskIterator {
        public WorkTask getNext();
        public boolean hasMore();
    }
    public static class FIFOIterator implements WorkTaskIterator{
        ArrayList<WorkTask> workTasks;
        int currentIndex;
        public FIFOIterator(WorkTaskCollection collection){
            currentIndex = 0;
            workTasks = new ArrayList<WorkTask>();
            int i = 0;
            while (collection.get(i) != null) {
                workTasks.add(collection.get(i));
                i++;
            }
        }
        public WorkTask getNext(){
            return workTasks.get(currentIndex++);
        }
        public boolean hasMore(){
            return currentIndex < workTasks.size();
        }
    }
    public static class PriorityIterator implements WorkTaskIterator{
        ArrayList<WorkTask> workTasks;
        int currentIndex;
        public PriorityIterator(WorkTaskCollection collection){
            currentIndex = 0;
            workTasks = new ArrayList<WorkTask>();
            int i = 0;
            while (collection.get(i) != null) {
                workTasks.add(collection.get(i));
                i++;
            }
            workTasks.sort((a, b) -> { return -1 * a.compareTo(b); });
        }
        public WorkTask getNext(){
            return workTasks.get(currentIndex++);
        }
        public boolean hasMore(){
            return currentIndex < workTasks.size();
        }
    }
    public static class TopPriorityIterator implements WorkTaskIterator{
        ArrayList<WorkTask> workTasks;
        int currentIndex;
        public TopPriorityIterator(WorkTaskCollection collection){
            currentIndex = 0;
            workTasks = new ArrayList<WorkTask>();
            int i = 0;
            while (collection.get(i) != null) {
                if(collection.get(i).getPriority() == collection.getTopPriority()){
                    workTasks.add(collection.get(i));
                }
                i++;
            }
        }
        public WorkTask getNext(){
            return workTasks.get(currentIndex++);
        }
        public boolean hasMore(){
            return currentIndex < workTasks.size();
        }
    }

    public static interface WorkTaskCollection {
        public FIFOIterator createIterator();
        public PriorityIterator createPriorityIterator();
        public TopPriorityIterator createTopPriorityIterator();
        public int getTopPriority();
        public WorkTask get(int index);
    }
    public static class HouseworkCollection implements WorkTaskCollection{
        ArrayList<Housework> houseworks;
        int topPriority;
        public HouseworkCollection(){
            houseworks = new ArrayList<Housework>();
            topPriority = 0;
        }
        public void add(Housework hw){
            if(houseworks.size() == 0 || topPriority < hw.getPriority()){
                topPriority = hw.getPriority();
            }
            houseworks.add(hw);
        }
        public FIFOIterator createIterator(){
            return new FIFOIterator(this);
        }
        public PriorityIterator createPriorityIterator(){
            return new PriorityIterator(this);
        }
        public TopPriorityIterator createTopPriorityIterator(){
            return new TopPriorityIterator(this);
        }
        public int getTopPriority(){
            return topPriority;
        }
        public Housework get(int index){
            if(index < houseworks.size()){
                return houseworks.get(index);
            }
            return null;
        }
    }
    public static class HomeworkCollection implements WorkTaskCollection{
        ArrayList<Homework> homeworks;
        int topPriority;
        public HomeworkCollection(){
            homeworks = new ArrayList<Homework>();
            topPriority = 0;
        }
        public void add(Homework hw){
            if(homeworks.size() == 0 || topPriority < hw.getPriority()){
                topPriority = hw.getPriority();
            }
            homeworks.add(hw);
        }
        public FIFOIterator createIterator(){
            return new FIFOIterator(this);
        }
        public PriorityIterator createPriorityIterator(){
            return new PriorityIterator(this);
        }
        public TopPriorityIterator createTopPriorityIterator(){
            return new TopPriorityIterator(this);
        }
        public int getTopPriority(){
            return topPriority;
        }
        public Homework get(int index){
            if(index < homeworks.size()){
                return homeworks.get(index);
            }
            return null;
        }
    }
    public static class WorkOutCollection implements WorkTaskCollection{
        ArrayList<WorkOut> workOuts;
        int topPriority;
        public WorkOutCollection(){
            workOuts = new ArrayList<WorkOut>();
            topPriority = 0;
        }
        public void add(WorkOut wo){
            if(workOuts.size() == 0 || topPriority < wo.getPriority()){
                topPriority = wo.getPriority();
            }
            workOuts.add(wo);
        }
        public FIFOIterator createIterator(){
            return new FIFOIterator(this);
        }
        public PriorityIterator createPriorityIterator(){
            return new PriorityIterator(this);
        }
        public TopPriorityIterator createTopPriorityIterator(){
            return new TopPriorityIterator(this);
        }
        public int getTopPriority(){
            return topPriority;
        }
        public WorkOut get(int index){
            if(index < workOuts.size()){
                return workOuts.get(index);
            }
            return null;
        }
    }

    public static void displayWorkTask(WorkTaskIterator wTaskIterator){
        while (wTaskIterator.hasMore()) {
            wTaskIterator.getNext().show();
        }
        System.err.println();
    }
    public static void main (String[] args){
        HouseworkCollection houseworks = new HouseworkCollection();
        houseworks.add(new Housework("Clean the house", 4));
        houseworks.add(new Housework("Clean the bedroom", 3));
        houseworks.add(new Housework("Clean the bathroom", 2));
        houseworks.add(new Housework("Do the laundry", 5));
        houseworks.add(new Housework("Iron the clothes", 1));
        houseworks.add(new Housework("Water the plants", 1));
        houseworks.add(new Housework("Take out the trash", 1));
        houseworks.add(new Housework("Tidy up the room", 5));
        houseworks.add(new Housework("Feed the cats", 5));

        System.err.println("---Display houseworks with FIFO Iterator---");
        displayWorkTask(houseworks.createIterator());
        System.err.println("---Display houseworks with Priority Iterator---");
        displayWorkTask(houseworks.createPriorityIterator());
        System.err.println("---Display houseworks with Top Priority Iterator---");
        displayWorkTask(houseworks.createTopPriorityIterator());

        HomeworkCollection homeworks = new HomeworkCollection();
        homeworks.add(new Homework("English", 5, LocalDate.of(2025, 8, 29)));
        homeworks.add(new Homework("Math", 3, LocalDate.of(2025, 9, 10)));
        homeworks.add(new Homework("Computer", 3, LocalDate.of(2025, 9, 9)));
        homeworks.add(new Homework("Science", 1, LocalDate.of(2025, 10, 3)));
        homeworks.add(new Homework("Thai", 4, LocalDate.of(2025, 9, 1)));

        System.err.println("---Display homeworks with FIFO Iterator---");
        displayWorkTask(homeworks.createIterator());
        System.err.println("---Display homeworks with Priority Iterator---");
        displayWorkTask(homeworks.createPriorityIterator());
        System.err.println("---Display homeworks with Top Priority Iterator---");
        displayWorkTask(homeworks.createTopPriorityIterator());

        WorkOutCollection workouts = new WorkOutCollection();
        workouts.add(new WorkOut("Jump rope", 1, 10));
        workouts.add(new WorkOut("Jogging", 3, 30));
        workouts.add(new WorkOut("Stretch", 5, 5));

        System.err.println("---Display workouts with FIFO Iterator---");
        displayWorkTask(workouts.createIterator());
        System.err.println("---Display workouts with Priority Iterator---");
        displayWorkTask(workouts.createPriorityIterator());
        System.err.println("---Display workouts with Top Priority Iterator---");
        displayWorkTask(workouts.createTopPriorityIterator());
    }
}