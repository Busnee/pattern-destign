using Library;

namespace ATM
{    
    partial class Form1
    {       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnChackBalance = new Button();
            btnTranfer = new Button();
            panelMenu = new Panel();
            btnWithdrawWithoutCard = new Button();
            btnExit = new Button();
            label5 = new Label();
            label4 = new Label();
            panelTranfer3 = new Panel();
            label32 = new Label();
            btnTranfer3Continue = new Button();
            richTextBoxTranferStatement = new RichTextBox();
            btnTranfer3Exit = new Button();
            label33 = new Label();
            label34 = new Label();
            panelLogin = new Panel();
            label6 = new Label();
            btnLogin = new Button();
            textBoxLoginPassword = new TextBox();
            label2 = new Label();
            textBoxLoginAccNum = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panelDeposit1 = new Panel();
            label7 = new Label();
            btnDeposit1Cancel = new Button();
            btnDeposit1Next = new Button();
            textBoxDepositAmount = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panelDeposit2 = new Panel();
            label8 = new Label();
            btnDeposit2Back = new Button();
            richTextBoxDepositInformation = new RichTextBox();
            btnDeposit2Confirm = new Button();
            label11 = new Label();
            label12 = new Label();
            panelDeposit3 = new Panel();
            label13 = new Label();
            btnDeposit3Continue = new Button();
            richTextBoxDepositStatement = new RichTextBox();
            btnDeposit3Exit = new Button();
            label14 = new Label();
            label15 = new Label();
            panelWithDraw1 = new Panel();
            label16 = new Label();
            btnWithDraw1Cancel = new Button();
            btnWithDraw1Next = new Button();
            textBoxWithDrawAmount = new TextBox();
            label17 = new Label();
            label18 = new Label();
            panelWithDraw3 = new Panel();
            label24 = new Label();
            label22 = new Label();
            btnWithDraw3Continue = new Button();
            richTextBoxWithDrawStatement = new RichTextBox();
            btnWithDraw3Exit = new Button();
            label23 = new Label();
            panelTranfer1 = new Panel();
            textBoxTranferAmount = new TextBox();
            label28 = new Label();
            label25 = new Label();
            btnTranfer1Cancel = new Button();
            btnTranfer1Next = new Button();
            textBoxTranferRecvNum = new TextBox();
            label26 = new Label();
            label27 = new Label();
            panelWithDraw2 = new Panel();
            label21 = new Label();
            label19 = new Label();
            btnWithDraw2Back = new Button();
            richTextBoxWithDrawInformation = new RichTextBox();
            btnWithDraw2Confirm = new Button();
            label20 = new Label();
            panelTranfer2 = new Panel();
            label29 = new Label();
            btnTranfer2Back = new Button();
            richTextBoxTranferInformation = new RichTextBox();
            btnTranfer2Confirm = new Button();
            label30 = new Label();
            label31 = new Label();
            panelCheckBalance = new Panel();
            label35 = new Label();
            btnCheckBalanceContinue = new Button();
            richTextBoxChekBalance = new RichTextBox();
            btnCheckBalanceExit = new Button();
            label36 = new Label();
            label37 = new Label();
            panelMenu.SuspendLayout();
            panelTranfer3.SuspendLayout();
            panelLogin.SuspendLayout();
            panelDeposit1.SuspendLayout();
            panelDeposit2.SuspendLayout();
            panelDeposit3.SuspendLayout();
            panelWithDraw1.SuspendLayout();
            panelWithDraw3.SuspendLayout();
            panelTranfer1.SuspendLayout();
            panelWithDraw2.SuspendLayout();
            panelTranfer2.SuspendLayout();
            panelCheckBalance.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(71, 122);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(186, 57);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(71, 185);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(186, 57);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnChackBalance
            // 
            btnChackBalance.Location = new Point(270, 122);
            btnChackBalance.Name = "btnChackBalance";
            btnChackBalance.Size = new Size(186, 57);
            btnChackBalance.TabIndex = 3;
            btnChackBalance.Text = "Chack Balance";
            btnChackBalance.UseVisualStyleBackColor = true;
            btnChackBalance.Click += btnChackBalance_Click;
            // 
            // btnTranfer
            // 
            btnTranfer.Location = new Point(71, 248);
            btnTranfer.Name = "btnTranfer";
            btnTranfer.Size = new Size(186, 57);
            btnTranfer.TabIndex = 2;
            btnTranfer.Text = "Tranfer";
            btnTranfer.UseVisualStyleBackColor = true;
            btnTranfer.Click += btnTranfer_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnWithdrawWithoutCard);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(label5);
            panelMenu.Controls.Add(label4);
            panelMenu.Controls.Add(btnChackBalance);
            panelMenu.Controls.Add(btnTranfer);
            panelMenu.Controls.Add(btnDeposit);
            panelMenu.Controls.Add(btnWithdraw);
            panelMenu.Location = new Point(12, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(523, 426);
            panelMenu.TabIndex = 4;
            // 
            // btnWithdrawWithoutCard
            // 
            btnWithdrawWithoutCard.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdrawWithoutCard.Location = new Point(270, 186);
            btnWithdrawWithoutCard.Name = "btnWithdrawWithoutCard";
            btnWithdrawWithoutCard.Size = new Size(186, 57);
            btnWithdrawWithoutCard.TabIndex = 20;
            btnWithdrawWithoutCard.Text = "Withdraw without card";
            btnWithdrawWithoutCard.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(270, 248);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(186, 57);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 12);
            label5.Name = "label5";
            label5.Size = new Size(91, 45);
            label5.TabIndex = 8;
            label5.Text = "ATM";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(204, 52);
            label4.Name = "label4";
            label4.Size = new Size(106, 45);
            label4.TabIndex = 5;
            label4.Text = "Menu";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTranfer3
            // 
            panelTranfer3.Controls.Add(label32);
            panelTranfer3.Controls.Add(btnTranfer3Continue);
            panelTranfer3.Controls.Add(richTextBoxTranferStatement);
            panelTranfer3.Controls.Add(btnTranfer3Exit);
            panelTranfer3.Controls.Add(label33);
            panelTranfer3.Controls.Add(label34);
            panelTranfer3.Location = new Point(12, 12);
            panelTranfer3.Name = "panelTranfer3";
            panelTranfer3.Size = new Size(523, 426);
            panelTranfer3.TabIndex = 18;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(420, 12);
            label32.Name = "label32";
            label32.Size = new Size(91, 45);
            label32.TabIndex = 12;
            label32.Text = "ATM";
            label32.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTranfer3Continue
            // 
            btnTranfer3Continue.Location = new Point(344, 333);
            btnTranfer3Continue.Name = "btnTranfer3Continue";
            btnTranfer3Continue.Size = new Size(112, 34);
            btnTranfer3Continue.TabIndex = 11;
            btnTranfer3Continue.Text = "Continue";
            btnTranfer3Continue.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer3Continue.UseVisualStyleBackColor = true;
            btnTranfer3Continue.Click += btnTranfer3Continue_Click;
            // 
            // richTextBoxTranferStatement
            // 
            richTextBoxTranferStatement.BackColor = Color.White;
            richTextBoxTranferStatement.ForeColor = Color.Black;
            richTextBoxTranferStatement.Location = new Point(84, 152);
            richTextBoxTranferStatement.Name = "richTextBoxTranferStatement";
            richTextBoxTranferStatement.ReadOnly = true;
            richTextBoxTranferStatement.Size = new Size(372, 135);
            richTextBoxTranferStatement.TabIndex = 10;
            richTextBoxTranferStatement.Text = "";
            // 
            // btnTranfer3Exit
            // 
            btnTranfer3Exit.Location = new Point(344, 293);
            btnTranfer3Exit.Name = "btnTranfer3Exit";
            btnTranfer3Exit.Size = new Size(112, 34);
            btnTranfer3Exit.TabIndex = 9;
            btnTranfer3Exit.Text = "Exit";
            btnTranfer3Exit.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer3Exit.UseVisualStyleBackColor = true;
            btnTranfer3Exit.Click += btnTranfer3Exit_Click;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(71, 116);
            label33.Name = "label33";
            label33.Size = new Size(104, 28);
            label33.TabIndex = 5;
            label33.Text = "statement";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(196, 52);
            label34.Name = "label34";
            label34.Size = new Size(128, 45);
            label34.TabIndex = 4;
            label34.Text = "Tranfer";
            label34.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(textBoxLoginPassword);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textBoxLoginAccNum);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label3);
            panelLogin.Location = new Point(12, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(523, 426);
            panelLogin.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(420, 12);
            label6.Name = "label6";
            label6.Size = new Size(91, 45);
            label6.TabIndex = 7;
            label6.Text = "ATM";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(210, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Enter";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Location = new Point(190, 195);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(200, 31);
            textBoxLoginPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 198);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // textBoxLoginAccNum
            // 
            textBoxLoginAccNum.Location = new Point(190, 135);
            textBoxLoginAccNum.Name = "textBoxLoginAccNum";
            textBoxLoginAccNum.Size = new Size(200, 31);
            textBoxLoginAccNum.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 138);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 5;
            label1.Text = "Account Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 52);
            label3.Name = "label3";
            label3.Size = new Size(104, 45);
            label3.TabIndex = 4;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDeposit1
            // 
            panelDeposit1.Controls.Add(label7);
            panelDeposit1.Controls.Add(btnDeposit1Cancel);
            panelDeposit1.Controls.Add(btnDeposit1Next);
            panelDeposit1.Controls.Add(textBoxDepositAmount);
            panelDeposit1.Controls.Add(label9);
            panelDeposit1.Controls.Add(label10);
            panelDeposit1.Location = new Point(12, 12);
            panelDeposit1.Name = "panelDeposit1";
            panelDeposit1.Size = new Size(523, 426);
            panelDeposit1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(420, 12);
            label7.Name = "label7";
            label7.Size = new Size(91, 45);
            label7.TabIndex = 13;
            label7.Text = "ATM";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeposit1Cancel
            // 
            btnDeposit1Cancel.Location = new Point(355, 333);
            btnDeposit1Cancel.Name = "btnDeposit1Cancel";
            btnDeposit1Cancel.Size = new Size(112, 34);
            btnDeposit1Cancel.TabIndex = 12;
            btnDeposit1Cancel.Text = "Cancel";
            btnDeposit1Cancel.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit1Cancel.UseVisualStyleBackColor = true;
            btnDeposit1Cancel.Click += btnDeposit1Cancel_Click;
            // 
            // btnDeposit1Next
            // 
            btnDeposit1Next.Location = new Point(355, 293);
            btnDeposit1Next.Name = "btnDeposit1Next";
            btnDeposit1Next.Size = new Size(112, 34);
            btnDeposit1Next.TabIndex = 9;
            btnDeposit1Next.Text = "Next";
            btnDeposit1Next.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit1Next.UseVisualStyleBackColor = true;
            btnDeposit1Next.Click += btnDeposit1Next_Click;
            // 
            // textBoxDepositAmount
            // 
            textBoxDepositAmount.Location = new Point(181, 158);
            textBoxDepositAmount.Name = "textBoxDepositAmount";
            textBoxDepositAmount.Size = new Size(200, 31);
            textBoxDepositAmount.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 161);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 5;
            label9.Text = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(196, 52);
            label10.Name = "label10";
            label10.Size = new Size(136, 45);
            label10.TabIndex = 4;
            label10.Text = "Deposit";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDeposit2
            // 
            panelDeposit2.Controls.Add(label8);
            panelDeposit2.Controls.Add(btnDeposit2Back);
            panelDeposit2.Controls.Add(richTextBoxDepositInformation);
            panelDeposit2.Controls.Add(btnDeposit2Confirm);
            panelDeposit2.Controls.Add(label11);
            panelDeposit2.Controls.Add(label12);
            panelDeposit2.Location = new Point(12, 12);
            panelDeposit2.Name = "panelDeposit2";
            panelDeposit2.Size = new Size(523, 426);
            panelDeposit2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(420, 12);
            label8.Name = "label8";
            label8.Size = new Size(91, 45);
            label8.TabIndex = 14;
            label8.Text = "ATM";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeposit2Back
            // 
            btnDeposit2Back.Location = new Point(344, 333);
            btnDeposit2Back.Name = "btnDeposit2Back";
            btnDeposit2Back.Size = new Size(112, 34);
            btnDeposit2Back.TabIndex = 13;
            btnDeposit2Back.Text = "Back";
            btnDeposit2Back.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit2Back.UseVisualStyleBackColor = true;
            btnDeposit2Back.Click += btnDeposit2Back_Click;
            // 
            // richTextBoxDepositInformation
            // 
            richTextBoxDepositInformation.BackColor = Color.White;
            richTextBoxDepositInformation.ForeColor = Color.Black;
            richTextBoxDepositInformation.Location = new Point(84, 152);
            richTextBoxDepositInformation.Name = "richTextBoxDepositInformation";
            richTextBoxDepositInformation.ReadOnly = true;
            richTextBoxDepositInformation.Size = new Size(372, 135);
            richTextBoxDepositInformation.TabIndex = 10;
            richTextBoxDepositInformation.Text = "";
            // 
            // btnDeposit2Confirm
            // 
            btnDeposit2Confirm.Location = new Point(344, 293);
            btnDeposit2Confirm.Name = "btnDeposit2Confirm";
            btnDeposit2Confirm.Size = new Size(112, 34);
            btnDeposit2Confirm.TabIndex = 9;
            btnDeposit2Confirm.Text = "Confirm";
            btnDeposit2Confirm.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit2Confirm.UseVisualStyleBackColor = true;
            btnDeposit2Confirm.Click += btnDeposit2Confirm_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(71, 116);
            label11.Name = "label11";
            label11.Size = new Size(275, 28);
            label11.TabIndex = 5;
            label11.Text = "please verify the information";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(196, 52);
            label12.Name = "label12";
            label12.Size = new Size(136, 45);
            label12.TabIndex = 4;
            label12.Text = "Deposit";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDeposit3
            // 
            panelDeposit3.Controls.Add(label13);
            panelDeposit3.Controls.Add(btnDeposit3Continue);
            panelDeposit3.Controls.Add(richTextBoxDepositStatement);
            panelDeposit3.Controls.Add(btnDeposit3Exit);
            panelDeposit3.Controls.Add(label14);
            panelDeposit3.Controls.Add(label15);
            panelDeposit3.Location = new Point(12, 12);
            panelDeposit3.Name = "panelDeposit3";
            panelDeposit3.Size = new Size(523, 426);
            panelDeposit3.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(420, 12);
            label13.Name = "label13";
            label13.Size = new Size(91, 45);
            label13.TabIndex = 12;
            label13.Text = "ATM";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDeposit3Continue
            // 
            btnDeposit3Continue.Location = new Point(344, 333);
            btnDeposit3Continue.Name = "btnDeposit3Continue";
            btnDeposit3Continue.Size = new Size(112, 34);
            btnDeposit3Continue.TabIndex = 11;
            btnDeposit3Continue.Text = "Continue";
            btnDeposit3Continue.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit3Continue.UseVisualStyleBackColor = true;
            btnDeposit3Continue.Click += btnDeposit3Continue_Click;
            // 
            // richTextBoxDepositStatement
            // 
            richTextBoxDepositStatement.BackColor = Color.White;
            richTextBoxDepositStatement.ForeColor = Color.Black;
            richTextBoxDepositStatement.Location = new Point(84, 152);
            richTextBoxDepositStatement.Name = "richTextBoxDepositStatement";
            richTextBoxDepositStatement.ReadOnly = true;
            richTextBoxDepositStatement.Size = new Size(372, 135);
            richTextBoxDepositStatement.TabIndex = 10;
            richTextBoxDepositStatement.Text = "";
            // 
            // btnDeposit3Exit
            // 
            btnDeposit3Exit.Location = new Point(344, 293);
            btnDeposit3Exit.Name = "btnDeposit3Exit";
            btnDeposit3Exit.Size = new Size(112, 34);
            btnDeposit3Exit.TabIndex = 9;
            btnDeposit3Exit.Text = "Exit";
            btnDeposit3Exit.TextAlign = ContentAlignment.MiddleRight;
            btnDeposit3Exit.UseVisualStyleBackColor = true;
            btnDeposit3Exit.Click += btnDeposit3Exit_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(71, 116);
            label14.Name = "label14";
            label14.Size = new Size(104, 28);
            label14.TabIndex = 5;
            label14.Text = "statement";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(196, 52);
            label15.Name = "label15";
            label15.Size = new Size(136, 45);
            label15.TabIndex = 4;
            label15.Text = "Deposit";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelWithDraw1
            // 
            panelWithDraw1.Controls.Add(label16);
            panelWithDraw1.Controls.Add(btnWithDraw1Cancel);
            panelWithDraw1.Controls.Add(btnWithDraw1Next);
            panelWithDraw1.Controls.Add(textBoxWithDrawAmount);
            panelWithDraw1.Controls.Add(label17);
            panelWithDraw1.Controls.Add(label18);
            panelWithDraw1.Location = new Point(12, 12);
            panelWithDraw1.Name = "panelWithDraw1";
            panelWithDraw1.Size = new Size(523, 426);
            panelWithDraw1.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(420, 12);
            label16.Name = "label16";
            label16.Size = new Size(91, 45);
            label16.TabIndex = 13;
            label16.Text = "ATM";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnWithDraw1Cancel
            // 
            btnWithDraw1Cancel.Location = new Point(355, 333);
            btnWithDraw1Cancel.Name = "btnWithDraw1Cancel";
            btnWithDraw1Cancel.Size = new Size(112, 34);
            btnWithDraw1Cancel.TabIndex = 12;
            btnWithDraw1Cancel.Text = "Cancel";
            btnWithDraw1Cancel.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw1Cancel.UseVisualStyleBackColor = true;
            btnWithDraw1Cancel.Click += btnWithDraw1Cancel_Click;
            // 
            // btnWithDraw1Next
            // 
            btnWithDraw1Next.Location = new Point(355, 293);
            btnWithDraw1Next.Name = "btnWithDraw1Next";
            btnWithDraw1Next.Size = new Size(112, 34);
            btnWithDraw1Next.TabIndex = 9;
            btnWithDraw1Next.Text = "Next";
            btnWithDraw1Next.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw1Next.UseVisualStyleBackColor = true;
            btnWithDraw1Next.Click += btnWithDraw1Next_Click;
            // 
            // textBoxWithDrawAmount
            // 
            textBoxWithDrawAmount.Location = new Point(181, 158);
            textBoxWithDrawAmount.Name = "textBoxWithDrawAmount";
            textBoxWithDrawAmount.Size = new Size(200, 31);
            textBoxWithDrawAmount.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(87, 161);
            label17.Name = "label17";
            label17.Size = new Size(77, 25);
            label17.TabIndex = 5;
            label17.Text = "Amount";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(192, 52);
            label18.Name = "label18";
            label18.Size = new Size(172, 45);
            label18.TabIndex = 4;
            label18.Text = "WithDraw";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelWithDraw3
            // 
            panelWithDraw3.Controls.Add(label24);
            panelWithDraw3.Controls.Add(label22);
            panelWithDraw3.Controls.Add(btnWithDraw3Continue);
            panelWithDraw3.Controls.Add(richTextBoxWithDrawStatement);
            panelWithDraw3.Controls.Add(btnWithDraw3Exit);
            panelWithDraw3.Controls.Add(label23);
            panelWithDraw3.Location = new Point(12, 12);
            panelWithDraw3.Name = "panelWithDraw3";
            panelWithDraw3.Size = new Size(523, 426);
            panelWithDraw3.TabIndex = 15;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(192, 51);
            label24.Name = "label24";
            label24.Size = new Size(172, 45);
            label24.TabIndex = 13;
            label24.Text = "WithDraw";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(420, 12);
            label22.Name = "label22";
            label22.Size = new Size(91, 45);
            label22.TabIndex = 12;
            label22.Text = "ATM";
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnWithDraw3Continue
            // 
            btnWithDraw3Continue.Location = new Point(344, 333);
            btnWithDraw3Continue.Name = "btnWithDraw3Continue";
            btnWithDraw3Continue.Size = new Size(112, 34);
            btnWithDraw3Continue.TabIndex = 11;
            btnWithDraw3Continue.Text = "Continue";
            btnWithDraw3Continue.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw3Continue.UseVisualStyleBackColor = true;
            btnWithDraw3Continue.Click += btnWithDraw3Continue_Click;
            // 
            // richTextBoxWithDrawStatement
            // 
            richTextBoxWithDrawStatement.BackColor = Color.White;
            richTextBoxWithDrawStatement.ForeColor = Color.Black;
            richTextBoxWithDrawStatement.Location = new Point(84, 152);
            richTextBoxWithDrawStatement.Name = "richTextBoxWithDrawStatement";
            richTextBoxWithDrawStatement.ReadOnly = true;
            richTextBoxWithDrawStatement.Size = new Size(372, 135);
            richTextBoxWithDrawStatement.TabIndex = 10;
            richTextBoxWithDrawStatement.Text = "";
            // 
            // btnWithDraw3Exit
            // 
            btnWithDraw3Exit.Location = new Point(344, 293);
            btnWithDraw3Exit.Name = "btnWithDraw3Exit";
            btnWithDraw3Exit.Size = new Size(112, 34);
            btnWithDraw3Exit.TabIndex = 9;
            btnWithDraw3Exit.Text = "Exit";
            btnWithDraw3Exit.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw3Exit.UseVisualStyleBackColor = true;
            btnWithDraw3Exit.Click += btnWithDraw3Exit_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(71, 116);
            label23.Name = "label23";
            label23.Size = new Size(104, 28);
            label23.TabIndex = 5;
            label23.Text = "statement";
            // 
            // panelTranfer1
            // 
            panelTranfer1.Controls.Add(textBoxTranferAmount);
            panelTranfer1.Controls.Add(label28);
            panelTranfer1.Controls.Add(label25);
            panelTranfer1.Controls.Add(btnTranfer1Cancel);
            panelTranfer1.Controls.Add(btnTranfer1Next);
            panelTranfer1.Controls.Add(textBoxTranferRecvNum);
            panelTranfer1.Controls.Add(label26);
            panelTranfer1.Controls.Add(label27);
            panelTranfer1.Location = new Point(12, 12);
            panelTranfer1.Name = "panelTranfer1";
            panelTranfer1.Size = new Size(523, 426);
            panelTranfer1.TabIndex = 16;
            // 
            // textBoxTranferAmount
            // 
            textBoxTranferAmount.Location = new Point(205, 210);
            textBoxTranferAmount.Name = "textBoxTranferAmount";
            textBoxTranferAmount.Size = new Size(200, 31);
            textBoxTranferAmount.TabIndex = 15;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(111, 213);
            label28.Name = "label28";
            label28.Size = new Size(77, 25);
            label28.TabIndex = 14;
            label28.Text = "Amount";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(420, 12);
            label25.Name = "label25";
            label25.Size = new Size(91, 45);
            label25.TabIndex = 13;
            label25.Text = "ATM";
            label25.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTranfer1Cancel
            // 
            btnTranfer1Cancel.Location = new Point(355, 333);
            btnTranfer1Cancel.Name = "btnTranfer1Cancel";
            btnTranfer1Cancel.Size = new Size(112, 34);
            btnTranfer1Cancel.TabIndex = 12;
            btnTranfer1Cancel.Text = "Cancel";
            btnTranfer1Cancel.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer1Cancel.UseVisualStyleBackColor = true;
            btnTranfer1Cancel.Click += btnTranfer1Cancel_Click;
            // 
            // btnTranfer1Next
            // 
            btnTranfer1Next.Location = new Point(355, 293);
            btnTranfer1Next.Name = "btnTranfer1Next";
            btnTranfer1Next.Size = new Size(112, 34);
            btnTranfer1Next.TabIndex = 9;
            btnTranfer1Next.Text = "Next";
            btnTranfer1Next.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer1Next.UseVisualStyleBackColor = true;
            btnTranfer1Next.Click += btnTranfer1Next_Click;
            // 
            // textBoxTranferRecvNum
            // 
            textBoxTranferRecvNum.Location = new Point(205, 150);
            textBoxTranferRecvNum.Name = "textBoxTranferRecvNum";
            textBoxTranferRecvNum.Size = new Size(200, 31);
            textBoxTranferRecvNum.TabIndex = 6;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(42, 156);
            label26.Name = "label26";
            label26.Size = new Size(146, 25);
            label26.TabIndex = 5;
            label26.Text = "Receiver Number";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(196, 52);
            label27.Name = "label27";
            label27.Size = new Size(128, 45);
            label27.TabIndex = 4;
            label27.Text = "Tranfer";
            label27.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelWithDraw2
            // 
            panelWithDraw2.Controls.Add(label21);
            panelWithDraw2.Controls.Add(label19);
            panelWithDraw2.Controls.Add(btnWithDraw2Back);
            panelWithDraw2.Controls.Add(richTextBoxWithDrawInformation);
            panelWithDraw2.Controls.Add(btnWithDraw2Confirm);
            panelWithDraw2.Controls.Add(label20);
            panelWithDraw2.Location = new Point(12, 12);
            panelWithDraw2.Name = "panelWithDraw2";
            panelWithDraw2.Size = new Size(523, 426);
            panelWithDraw2.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(192, 52);
            label21.Name = "label21";
            label21.Size = new Size(172, 45);
            label21.TabIndex = 15;
            label21.Text = "WithDraw";
            label21.TextAlign = ContentAlignment.TopCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(420, 12);
            label19.Name = "label19";
            label19.Size = new Size(91, 45);
            label19.TabIndex = 14;
            label19.Text = "ATM";
            label19.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnWithDraw2Back
            // 
            btnWithDraw2Back.Location = new Point(344, 333);
            btnWithDraw2Back.Name = "btnWithDraw2Back";
            btnWithDraw2Back.Size = new Size(112, 34);
            btnWithDraw2Back.TabIndex = 13;
            btnWithDraw2Back.Text = "Back";
            btnWithDraw2Back.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw2Back.UseVisualStyleBackColor = true;
            btnWithDraw2Back.Click += btnWithDraw2Back_Click;
            // 
            // richTextBoxWithDrawInformation
            // 
            richTextBoxWithDrawInformation.BackColor = Color.White;
            richTextBoxWithDrawInformation.ForeColor = Color.Black;
            richTextBoxWithDrawInformation.Location = new Point(84, 152);
            richTextBoxWithDrawInformation.Name = "richTextBoxWithDrawInformation";
            richTextBoxWithDrawInformation.ReadOnly = true;
            richTextBoxWithDrawInformation.Size = new Size(372, 135);
            richTextBoxWithDrawInformation.TabIndex = 10;
            richTextBoxWithDrawInformation.Text = "";
            // 
            // btnWithDraw2Confirm
            // 
            btnWithDraw2Confirm.Location = new Point(344, 293);
            btnWithDraw2Confirm.Name = "btnWithDraw2Confirm";
            btnWithDraw2Confirm.Size = new Size(112, 34);
            btnWithDraw2Confirm.TabIndex = 9;
            btnWithDraw2Confirm.Text = "Confirm";
            btnWithDraw2Confirm.TextAlign = ContentAlignment.MiddleRight;
            btnWithDraw2Confirm.UseVisualStyleBackColor = true;
            btnWithDraw2Confirm.Click += btnWithDraw2Confirm_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(71, 116);
            label20.Name = "label20";
            label20.Size = new Size(275, 28);
            label20.TabIndex = 5;
            label20.Text = "please verify the information";
            // 
            // panelTranfer2
            // 
            panelTranfer2.Controls.Add(label29);
            panelTranfer2.Controls.Add(btnTranfer2Back);
            panelTranfer2.Controls.Add(richTextBoxTranferInformation);
            panelTranfer2.Controls.Add(btnTranfer2Confirm);
            panelTranfer2.Controls.Add(label30);
            panelTranfer2.Controls.Add(label31);
            panelTranfer2.Location = new Point(12, 12);
            panelTranfer2.Name = "panelTranfer2";
            panelTranfer2.Size = new Size(523, 426);
            panelTranfer2.TabIndex = 17;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(420, 12);
            label29.Name = "label29";
            label29.Size = new Size(91, 45);
            label29.TabIndex = 14;
            label29.Text = "ATM";
            label29.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTranfer2Back
            // 
            btnTranfer2Back.Location = new Point(344, 333);
            btnTranfer2Back.Name = "btnTranfer2Back";
            btnTranfer2Back.Size = new Size(112, 34);
            btnTranfer2Back.TabIndex = 13;
            btnTranfer2Back.Text = "Back";
            btnTranfer2Back.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer2Back.UseVisualStyleBackColor = true;
            btnTranfer2Back.Click += btnTranfer2Back_Click;
            // 
            // richTextBoxTranferInformation
            // 
            richTextBoxTranferInformation.BackColor = Color.White;
            richTextBoxTranferInformation.ForeColor = Color.Black;
            richTextBoxTranferInformation.Location = new Point(84, 152);
            richTextBoxTranferInformation.Name = "richTextBoxTranferInformation";
            richTextBoxTranferInformation.ReadOnly = true;
            richTextBoxTranferInformation.Size = new Size(372, 135);
            richTextBoxTranferInformation.TabIndex = 10;
            richTextBoxTranferInformation.Text = "";
            // 
            // btnTranfer2Confirm
            // 
            btnTranfer2Confirm.Location = new Point(344, 293);
            btnTranfer2Confirm.Name = "btnTranfer2Confirm";
            btnTranfer2Confirm.Size = new Size(112, 34);
            btnTranfer2Confirm.TabIndex = 9;
            btnTranfer2Confirm.Text = "Confirm";
            btnTranfer2Confirm.TextAlign = ContentAlignment.MiddleRight;
            btnTranfer2Confirm.UseVisualStyleBackColor = true;
            btnTranfer2Confirm.Click += btnTranfer2Confirm_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(71, 116);
            label30.Name = "label30";
            label30.Size = new Size(275, 28);
            label30.TabIndex = 5;
            label30.Text = "please verify the information";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(196, 52);
            label31.Name = "label31";
            label31.Size = new Size(128, 45);
            label31.TabIndex = 4;
            label31.Text = "Tranfer";
            label31.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCheckBalance
            // 
            panelCheckBalance.Controls.Add(label35);
            panelCheckBalance.Controls.Add(btnCheckBalanceContinue);
            panelCheckBalance.Controls.Add(richTextBoxChekBalance);
            panelCheckBalance.Controls.Add(btnCheckBalanceExit);
            panelCheckBalance.Controls.Add(label36);
            panelCheckBalance.Controls.Add(label37);
            panelCheckBalance.Location = new Point(12, 12);
            panelCheckBalance.Name = "panelCheckBalance";
            panelCheckBalance.Size = new Size(523, 426);
            panelCheckBalance.TabIndex = 19;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label35.Location = new Point(420, 12);
            label35.Name = "label35";
            label35.Size = new Size(91, 45);
            label35.TabIndex = 12;
            label35.Text = "ATM";
            label35.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCheckBalanceContinue
            // 
            btnCheckBalanceContinue.Location = new Point(344, 333);
            btnCheckBalanceContinue.Name = "btnCheckBalanceContinue";
            btnCheckBalanceContinue.Size = new Size(112, 34);
            btnCheckBalanceContinue.TabIndex = 11;
            btnCheckBalanceContinue.Text = "Continue";
            btnCheckBalanceContinue.TextAlign = ContentAlignment.MiddleRight;
            btnCheckBalanceContinue.UseVisualStyleBackColor = true;
            btnCheckBalanceContinue.Click += btnCheckBalanceContinue_Click;
            // 
            // richTextBoxChekBalance
            // 
            richTextBoxChekBalance.BackColor = Color.White;
            richTextBoxChekBalance.ForeColor = Color.Black;
            richTextBoxChekBalance.Location = new Point(84, 152);
            richTextBoxChekBalance.Name = "richTextBoxChekBalance";
            richTextBoxChekBalance.ReadOnly = true;
            richTextBoxChekBalance.Size = new Size(372, 135);
            richTextBoxChekBalance.TabIndex = 10;
            richTextBoxChekBalance.Text = "";
            // 
            // btnCheckBalanceExit
            // 
            btnCheckBalanceExit.Location = new Point(344, 293);
            btnCheckBalanceExit.Name = "btnCheckBalanceExit";
            btnCheckBalanceExit.Size = new Size(112, 34);
            btnCheckBalanceExit.TabIndex = 9;
            btnCheckBalanceExit.Text = "Exit";
            btnCheckBalanceExit.TextAlign = ContentAlignment.MiddleRight;
            btnCheckBalanceExit.UseVisualStyleBackColor = true;
            btnCheckBalanceExit.Click += btnCheckBalanceExit_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label36.Location = new Point(71, 116);
            label36.Name = "label36";
            label36.Size = new Size(104, 28);
            label36.TabIndex = 5;
            label36.Text = "statement";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(163, 52);
            label37.Name = "label37";
            label37.Size = new Size(233, 45);
            label37.TabIndex = 4;
            label37.Text = "Check Balance";
            label37.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(panelMenu);
            Controls.Add(panelCheckBalance);
            Controls.Add(panelTranfer3);
            Controls.Add(panelTranfer2);
            Controls.Add(panelTranfer1);
            Controls.Add(panelWithDraw3);
            Controls.Add(panelWithDraw2);
            Controls.Add(panelWithDraw1);
            Controls.Add(panelDeposit3);
            Controls.Add(panelDeposit2);
            Controls.Add(panelDeposit1);
            Controls.Add(panelLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelTranfer3.ResumeLayout(false);
            panelTranfer3.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelDeposit1.ResumeLayout(false);
            panelDeposit1.PerformLayout();
            panelDeposit2.ResumeLayout(false);
            panelDeposit2.PerformLayout();
            panelDeposit3.ResumeLayout(false);
            panelDeposit3.PerformLayout();
            panelWithDraw1.ResumeLayout(false);
            panelWithDraw1.PerformLayout();
            panelWithDraw3.ResumeLayout(false);
            panelWithDraw3.PerformLayout();
            panelTranfer1.ResumeLayout(false);
            panelTranfer1.PerformLayout();
            panelWithDraw2.ResumeLayout(false);
            panelWithDraw2.PerformLayout();
            panelTranfer2.ResumeLayout(false);
            panelTranfer2.PerformLayout();
            panelCheckBalance.ResumeLayout(false);
            panelCheckBalance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnChackBalance;
        private Button btnTranfer;
        private Panel panelMenu;
        private Label label3;
        private Panel panelLogin;
        private Label label4;
        private Button btnLogin;
        private TextBox textBoxLoginPassword;
        private Label label2;
        private TextBox textBoxLoginAccNum;
        private Label label1;
        private Label label6;
        private Panel panelDeposit1;
        private Button btnDeposit1Next;
        private Label label10;
        private TextBox textBoxDepositAmount;
        private Label label9;
        private Panel panelDeposit2;
        private Button btnDeposit2Confirm;
        private Label label11;
        private Label label12;
        private RichTextBox richTextBoxDepositInformation;
        private Panel panelDeposit3;
        private RichTextBox richTextBoxDepositStatement;
        private Button btnDeposit3Exit;
        private Label label14;
        private Label label15;
        private Button btnDeposit1Cancel;
        private Button btnDeposit3Continue;
        private Button btnDeposit2Back;
        private Label label13;
        private Label label5;
        private Label label7;
        private Label label8;
        private Panel panelWithDraw1;
        private Label label16;
        private Button btnWithDraw1Cancel;
        private Button btnWithDraw1Next;
        private TextBox textBoxWithDrawAmount;
        private Label label17;
        private Label label18;
        private Panel panelWithDraw2;
        private Label label21;
        private Label label19;
        private Button btnWithDraw2Back;
        private RichTextBox richTextBoxWithDrawInformation;
        private Button btnWithDraw2Confirm;
        private Label label20;
        private Panel panelWithDraw3;
        private Label label24;
        private Label label22;
        private Button btnWithDraw3Continue;
        private RichTextBox richTextBoxWithDrawStatement;
        private Button btnWithDraw3Exit;
        private Label label23;
        private Panel panelTranfer1;
        private TextBox textBoxTranferAmount;
        private Label label28;
        private Label label25;
        private Button btnTranfer1Cancel;
        private Button btnTranfer1Next;
        private TextBox textBoxTranferRecvNum;
        private Label label26;
        private Label label27;
        private Panel panelTranfer2;
        private Label label29;
        private Button btnTranfer2Back;
        private RichTextBox richTextBoxTranferInformation;
        private Button btnTranfer2Confirm;
        private Label label30;
        private Label label31;
        private Panel panelTranfer3;
        private Label label32;
        private Button btnTranfer3Continue;
        private RichTextBox richTextBoxTranferStatement;
        private Button btnTranfer3Exit;
        private Label label33;
        private Label label34;
        private Panel panelCheckBalance;
        private Label label35;
        private Button btnCheckBalanceContinue;
        private RichTextBox richTextBoxChekBalance;
        private Button btnCheckBalanceExit;
        private Label label36;
        private Label label37;
        private Button btnWithdrawWithoutCard;
        private Button btnExit;
    }
}
