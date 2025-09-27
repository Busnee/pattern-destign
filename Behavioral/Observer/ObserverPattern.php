<?php
    $lastUserID = 0;

    class Song{
        private $title;
        private $artist;
        private $songwriter;
        private $composer;
        private $arrange;

        function __construct($title, $artist, $songwriter, $composer, $arrange)
        {
            $this->title = $title;
            $this->artist = $artist;
            $this->songwriter = $songwriter;
            $this->composer = $composer;
            $this->arrange = $arrange;
        }
        function show(){
            echo("title: $this->title, artist: $this->artist, lylics: $this->songwriter, composer: $this->composer, arrange: $this->arrange\n");
        }
        function getTitle(){
            return $this->title;
        }
        function getArtist(){
            return $this->artist;
        }
    }
    class Album{
        private $title;
        private $artist;
        private $totalTrack;
        private $titleTrackNumber;
        private $tracks = array();

        function __construct($title, $artist, $totalTrack, $titleTrackNumber)
        {
            $this->title = $title;
            $this->artist = $artist;
            $this->totalTrack = $totalTrack;
            $this->titleTrackNumber = $titleTrackNumber;
        }
        function show(){
            echo("title: $this->title, artist: $this->artist, totalTrack: $this->totalTrack, titleTrackNumber: $this->titleTrackNumber\n");
            $i =1;
            foreach( $this->tracks as $track){
                echo("-track$i- ");
                $track->show();
                $i++;
            }
        }
        function setTrack($trackNumber, $song){
            $this->tracks[$trackNumber] = $song;
        }
        function getTitle(){
            return $this->title;
        }
        function getArtist(){
            return $this->artist;
        }
        function getTitleTrack(){
            return $this->tracks[$this->titleTrackNumber];
        }
        function getTracks(){
            return $this->tracks;
        }
    }

    interface Publisher{
        function subscribe($observer);
        function unsubscribe($observer);
        function notifyMessage($message);
    }
    interface Observer{
        function updateMessage($message);
        function updateSong($song);
        function updateAlbum($album);
        function __toString();
    }

    class ArtistPublisher implements Publisher {
        private $observer = array();
        private $artist;

        function __construct($artist){
            $this->artist = $artist;
        }
        function subscribe($observer){
            array_push($this->observer, $observer);
        }
        function unsubscribe($observer){
            $target = [$observer];
            $this->observer = array_diff($this->observer, $target);
        }
        function notifyMessage($message){
            foreach( $this->observer as $ob){
                $ob->updateMessage($message);
            }
        }
        function notifySong($song){
            foreach( $this->observer as $ob){
                $ob->updateSong($song);
            }
        }
        function notifyAlbum($album){
            foreach( $this->observer as $ob){
                $ob->updateAlbum($album);
            }
        }
        function publishSong($song){
            $songTitle = $song->getTitle();
            echo("$this->artist released a new song name $songTitle\n");
            $this->notifySong($song);
        }
        function publishAlbum($album){
            $albumTitle = $album->getTitle();
            echo("$this->artist released a new album name $albumTitle\n");
            $this->notifyAlbum($album);
        }
    }
    class Audience implements Observer{
        private $id;
        private $name;
        private $favoriteSong = array();

        function __construct($name){
            global $lastUserID;

            $this->id = ++$lastUserID;
            $this->name = $name;
        }
        function __toString(){
            return $this->id;
        }
        function updateMessage($message){
            echo("$this->name >> $message\n");
        }
        function updateSong($song){
            $this->listen($song);
            $rand = rand(0,1);
            if($rand == 1){
                $this->addFavoritSong($song);
            }
        }
        function updateAlbum($album){
            foreach ($album->getTracks() as $track) {
                $this->listen($track);
                $rand = rand(0,1);
                if($rand == 1){
                    $this->addFavoritSong($track);
                }
            }
        }
        function listen($song){
            $songTitle = $song->getTitle();
            echo("$this->name is listening $songTitle...\n");
        }
        function addFavoritSong($song){
            $songTitle = $song->getTitle();
            echo("$this->name add $songTitle to favorit song\n");
            array_push($this->favoriteSong);
        }
    }
    class OnlineReporter implements Observer{
        private $id;
        private $belongTo;
        private $platform;

        function __construct($belongTo, $platform){
            global $lastUserID;

            $this->id = ++$lastUserID;
            $this->belongTo = $belongTo;
            $this->platform = $platform;
        }
        function __toString(){
            return $this->id;
        }
        function updateMessage($message){
            echo("$this->belongTo $this->platform >> $message\n");
        }
        function updateSong($song){
            $songTitle = $song->getTitle();
            $artist = $song->getArtist();
            $this->postArticle("$songTitle new song from $artist");
        }
        function updateAlbum($album){
            $albumTitle = $album->getTitle();
            $artist = $album->getArtist;
            $this->postArticle("$albumTitle new Album from $artist\n");
        }
        function postArticle($title){
            echo("$this->belongTo post article \"$title\" on $this->platform\n");
        }
    }
    class Reactor implements Observer{
        private $id;
        private $name;
        private $reactionQueue = array();

        function __construct($name){
            global $lastUserID;

            $this->id = ++$lastUserID;
            $this->name = $name;
        }
        function __toString(){
            return $this->id;
        }
        function updateMessage($message){
            echo("$this->name >> $message");
        }
        function updateSong($song){
            $this->addReactQueue($song);
        }
        function updateAlbum($album){
            $this->addReactQueue($album->getTitleTrack());
        }
        function react($song){
            $songTitle = $song->getTitle();
            echo("$this->name react to $songTitle\n");
        }
        function addReactQueue($song){
            array_push($this->reactionQueue, $song);
        }
        function reactAll() {
            foreach($this->reactionQueue as $song){
                $song = array_shift($this->reactionQueue);
                $this->react($song);
            }
        }
    }

    function main(){
        $strayKidsPublisher = new ArtistPublisher("Stray Kids");
        $_4evePublisher = new ArtistPublisher("4EVE");
        $NontTanotPublisher = new ArtistPublisher("Nont Tanont");

        $mana = new Audience("Mana");
        $manee = new Audience("Manee");
        $maliReat = new Reactor("Mali Reat");
        $tpopNews = new OnlineReporter("TPOP News", "X");
        
        $_4evePublisher->subscribe($mana);
        $NontTanotPublisher->subscribe($mana);
        
        $strayKidsPublisher->subscribe($manee);
        $NontTanotPublisher->subscribe($manee);
        
        $_4evePublisher->subscribe($tpopNews);
        $NontTanotPublisher->subscribe($tpopNews);

        $strayKidsPublisher->subscribe($maliReat);
        $_4evePublisher->subscribe($maliReat);       

        $song1 = new Song("หยดน้ำตา(TEARS)","4EVE","Worachet Thanupongcharat , Aran Nongpon", "Worachet Thanupongcharat", "Worachet Thanupongcharat");
        $_4evePublisher->publishSong($song1);
        echo("\n");

        $song2 = new Song("โต๊ะริม(Melt)", "Nont Tanont", "BOWKYLION", "BOWKYLION", "Guntapich, Yoryeeyee");
        $NontTanotPublisher->publishSong($song2);
        echo("\n");

        $NontTanotPublisher->notifyMessage("\"Nont EP.03 สุรุ่ยสุร่าย Concert\" Nont Tanont Concert will Show at 5-7 Saptember 2025");
        echo("\n");

        $album1 = new Album("Christmas EveL", "Stray Kids", 4, 1);
        $track1 = new Song("Christmas EveL","Stray Kids", "Bang Chan, Changbin, Han", "Bang Chan, Changbin, Han, HotSauce", "HotSauce, Bang Chan");
        $track2 = new Song("Christmas EveL","Stray Kids", "Bang Chan", "Bang Chan, Nickko Young", "Bang Chan, Nickko Young");
        $track3 = new Song("Christmas EveL","Stray Kids", "Han", "Han, Earattack", "Earattack");
        $track4 = new Song("Christmas EveL","Stray Kids", "Bang Chan, Changbin, Han, Felix, Junoflo", "Bang Chan, Changbin, Han, Versachoi", "Versachoi, Bang Chan");
        $album1->setTrack(1, $track1);
        $album1->setTrack(2, $track2);
        $album1->setTrack(3, $track3);
        $album1->setTrack(4, $track4);
        $strayKidsPublisher->publishAlbum($album1);
        echo("\n");

        $_4evePublisher->unsubscribe($mana);

        $song3 = new Song("Hot 2 Hot","4EVE", "GALCHANIE", "SpatChies, Mayojames", "SpatChies, Mayojames, RISK");
        $_4evePublisher->publishSong($song3);
        echo("\n");

        $maliReat->reactAll();
    }

    main();
?>