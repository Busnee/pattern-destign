using System;
using Library;

namespace MobileBanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            pictureBoxRefresh = new PictureBox();
            labelBalance = new Label();
            label2 = new Label();
            labelAccNumber = new Label();
            labelAccName = new Label();
            btnWithdrawWithoutCard = new Button();
            btnTranfer = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            panelTranfer1 = new Panel();
            btnTranfer1Cancel = new Button();
            label8 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            labelTranfer1Balance = new Label();
            labelTranfer1AccNumber = new Label();
            labelTranfer1AccName = new Label();
            label7 = new Label();
            panel5 = new Panel();
            btnTranfer1Next = new Button();
            textBoxTranfer1Amount = new TextBox();
            label5 = new Label();
            textBoxTranfer1RecvNumber = new TextBox();
            label3 = new Label();
            panelTranfer2 = new Panel();
            panel7 = new Panel();
            label11 = new Label();
            labelTranfer2RecvNumber = new Label();
            labelTranfer2RecvName = new Label();
            panel8 = new Panel();
            labelTranfer2Amount = new Label();
            label17 = new Label();
            btnTranfer2Confirm = new Button();
            btnTranfer2Cancel = new Button();
            label6 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            labelTranfer2AccBalance = new Label();
            labelTranfer2AccNumber = new Label();
            labelTranfer2AccName = new Label();
            label13 = new Label();
            panelWithdrawWithoutCard1 = new Panel();
            btnWithdrawWithoutCard1Cancel = new Button();
            label10 = new Label();
            label12 = new Label();
            panel9 = new Panel();
            labelWithdrawWithoutCard1AccBalance = new Label();
            labelWithdrawWithoutCard1AccNumber = new Label();
            labelWithdrawWithoutCard1AccName = new Label();
            label18 = new Label();
            panel10 = new Panel();
            btnWithdrawWithoutCard1Amount6 = new Button();
            btnWithdrawWithoutCard1Amount5 = new Button();
            btnWithdrawWithoutCard1Amount4 = new Button();
            btnWithdrawWithoutCard1Amount3 = new Button();
            btnWithdrawWithoutCard1Amount2 = new Button();
            btnWithdrawWithoutCard1Amount1 = new Button();
            btnWithdrawWithoutCard1Next = new Button();
            textBoxWithdrawWithoutCard1Amount = new TextBox();
            label19 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            panelMain.SuspendLayout();
            panelTranfer1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelTranfer2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panelWithdrawWithoutCard1.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "Bank Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(pictureBoxRefresh);
            panel1.Controls.Add(labelBalance);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelAccNumber);
            panel1.Controls.Add(labelAccName);
            panel1.Location = new Point(11, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 147);
            panel1.TabIndex = 1;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Image = (Image)resources.GetObject("pictureBoxRefresh.Image");
            pictureBoxRefresh.Location = new Point(298, 10);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(18, 18);
            pictureBoxRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRefresh.TabIndex = 26;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // labelBalance
            // 
            labelBalance.Anchor = AnchorStyles.Right;
            labelBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBalance.ForeColor = SystemColors.ControlLightLight;
            labelBalance.Location = new Point(106, 98);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(216, 37);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "balance";
            labelBalance.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Balance (฿)";
            // 
            // labelAccNumber
            // 
            labelAccNumber.AutoSize = true;
            labelAccNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAccNumber.ForeColor = SystemColors.ControlLightLight;
            labelAccNumber.Location = new Point(12, 38);
            labelAccNumber.Name = "labelAccNumber";
            labelAccNumber.Size = new Size(52, 25);
            labelAccNumber.TabIndex = 1;
            labelAccNumber.Text = "0000";
            // 
            // labelAccName
            // 
            labelAccName.AutoSize = true;
            labelAccName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAccName.ForeColor = SystemColors.ControlLightLight;
            labelAccName.Location = new Point(12, 10);
            labelAccName.Name = "labelAccName";
            labelAccName.Size = new Size(68, 28);
            labelAccName.TabIndex = 0;
            labelAccName.Text = "Name";
            // 
            // btnWithdrawWithoutCard
            // 
            btnWithdrawWithoutCard.BackColor = SystemColors.ButtonHighlight;
            btnWithdrawWithoutCard.Location = new Point(12, 296);
            btnWithdrawWithoutCard.Name = "btnWithdrawWithoutCard";
            btnWithdrawWithoutCard.Size = new Size(325, 57);
            btnWithdrawWithoutCard.TabIndex = 24;
            btnWithdrawWithoutCard.Text = "Withdraw without card";
            btnWithdrawWithoutCard.UseVisualStyleBackColor = false;
            btnWithdrawWithoutCard.Click += btnWithdrawWithoutCard_Click;
            // 
            // btnTranfer
            // 
            btnTranfer.BackColor = SystemColors.ButtonHighlight;
            btnTranfer.Location = new Point(12, 233);
            btnTranfer.Name = "btnTranfer";
            btnTranfer.Size = new Size(325, 57);
            btnTranfer.TabIndex = 23;
            btnTranfer.Text = "Tranfer";
            btnTranfer.UseVisualStyleBackColor = false;
            btnTranfer.Click += btnTranfer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Location = new Point(12, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 10);
            panel2.TabIndex = 25;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(btnWithdrawWithoutCard);
            panelMain.Controls.Add(btnTranfer);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(panel2);
            panelMain.Location = new Point(0, -1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(352, 562);
            panelMain.TabIndex = 26;
            // 
            // panelTranfer1
            // 
            panelTranfer1.BackColor = Color.Pink;
            panelTranfer1.Controls.Add(btnTranfer1Cancel);
            panelTranfer1.Controls.Add(label8);
            panelTranfer1.Controls.Add(label4);
            panelTranfer1.Controls.Add(panel4);
            panelTranfer1.Controls.Add(label7);
            panelTranfer1.Controls.Add(panel5);
            panelTranfer1.Location = new Point(0, 0);
            panelTranfer1.Name = "panelTranfer1";
            panelTranfer1.Size = new Size(352, 562);
            panelTranfer1.TabIndex = 27;
            // 
            // btnTranfer1Cancel
            // 
            btnTranfer1Cancel.BackColor = Color.Transparent;
            btnTranfer1Cancel.FlatAppearance.BorderColor = Color.LightPink;
            btnTranfer1Cancel.FlatAppearance.BorderSize = 0;
            btnTranfer1Cancel.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnTranfer1Cancel.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnTranfer1Cancel.FlatStyle = FlatStyle.Flat;
            btnTranfer1Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTranfer1Cancel.Location = new Point(304, -1);
            btnTranfer1Cancel.Name = "btnTranfer1Cancel";
            btnTranfer1Cancel.Size = new Size(45, 34);
            btnTranfer1Cancel.TabIndex = 28;
            btnTranfer1Cancel.Text = "X";
            btnTranfer1Cancel.TextAlign = ContentAlignment.TopCenter;
            btnTranfer1Cancel.UseVisualStyleBackColor = false;
            btnTranfer1Cancel.Click += btnTranfer1Cancel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 230);
            label8.Name = "label8";
            label8.Size = new Size(34, 28);
            label8.TabIndex = 27;
            label8.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 54);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 26;
            label4.Text = "From";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HighlightText;
            panel4.Controls.Add(labelTranfer1Balance);
            panel4.Controls.Add(labelTranfer1AccNumber);
            panel4.Controls.Add(labelTranfer1AccName);
            panel4.Location = new Point(11, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 119);
            panel4.TabIndex = 1;
            // 
            // labelTranfer1Balance
            // 
            labelTranfer1Balance.Anchor = AnchorStyles.Right;
            labelTranfer1Balance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTranfer1Balance.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer1Balance.Location = new Point(12, 67);
            labelTranfer1Balance.Name = "labelTranfer1Balance";
            labelTranfer1Balance.Size = new Size(216, 37);
            labelTranfer1Balance.TabIndex = 3;
            labelTranfer1Balance.Text = "balance ฿";
            labelTranfer1Balance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTranfer1AccNumber
            // 
            labelTranfer1AccNumber.AutoSize = true;
            labelTranfer1AccNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTranfer1AccNumber.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer1AccNumber.Location = new Point(12, 38);
            labelTranfer1AccNumber.Name = "labelTranfer1AccNumber";
            labelTranfer1AccNumber.Size = new Size(52, 25);
            labelTranfer1AccNumber.TabIndex = 1;
            labelTranfer1AccNumber.Text = "0000";
            // 
            // labelTranfer1AccName
            // 
            labelTranfer1AccName.AutoSize = true;
            labelTranfer1AccName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTranfer1AccName.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer1AccName.Location = new Point(12, 10);
            labelTranfer1AccName.Name = "labelTranfer1AccName";
            labelTranfer1AccName.Size = new Size(68, 28);
            labelTranfer1AccName.TabIndex = 0;
            labelTranfer1AccName.Text = "Name";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(93, 20);
            label7.Name = "label7";
            label7.Size = new Size(165, 32);
            label7.TabIndex = 0;
            label7.Text = "Tranfer";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 235, 235);
            panel5.Controls.Add(btnTranfer1Next);
            panel5.Controls.Add(textBoxTranfer1Amount);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBoxTranfer1RecvNumber);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(349, 301);
            panel5.TabIndex = 25;
            // 
            // btnTranfer1Next
            // 
            btnTranfer1Next.Location = new Point(11, 185);
            btnTranfer1Next.Name = "btnTranfer1Next";
            btnTranfer1Next.Size = new Size(321, 34);
            btnTranfer1Next.TabIndex = 4;
            btnTranfer1Next.Text = "Next";
            btnTranfer1Next.UseVisualStyleBackColor = true;
            btnTranfer1Next.Click += btnTranfer1Next_Click;
            // 
            // textBoxTranfer1Amount
            // 
            textBoxTranfer1Amount.Location = new Point(10, 133);
            textBoxTranfer1Amount.Name = "textBoxTranfer1Amount";
            textBoxTranfer1Amount.Size = new Size(321, 31);
            textBoxTranfer1Amount.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 2;
            label5.Text = "Amount";
            // 
            // textBoxTranfer1RecvNumber
            // 
            textBoxTranfer1RecvNumber.Location = new Point(11, 47);
            textBoxTranfer1RecvNumber.Name = "textBoxTranfer1RecvNumber";
            textBoxTranfer1RecvNumber.Size = new Size(321, 31);
            textBoxTranfer1RecvNumber.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 9);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 0;
            label3.Text = "Account Number";
            // 
            // panelTranfer2
            // 
            panelTranfer2.BackColor = Color.Pink;
            panelTranfer2.Controls.Add(panel7);
            panelTranfer2.Controls.Add(panel8);
            panelTranfer2.Controls.Add(btnTranfer2Cancel);
            panelTranfer2.Controls.Add(label6);
            panelTranfer2.Controls.Add(label9);
            panelTranfer2.Controls.Add(panel6);
            panelTranfer2.Controls.Add(label13);
            panelTranfer2.Location = new Point(-2, -1);
            panelTranfer2.Name = "panelTranfer2";
            panelTranfer2.Size = new Size(352, 562);
            panelTranfer2.TabIndex = 28;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.HighlightText;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(labelTranfer2RecvNumber);
            panel7.Controls.Add(labelTranfer2RecvName);
            panel7.Location = new Point(14, 246);
            panel7.Name = "panel7";
            panel7.Size = new Size(325, 107);
            panel7.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(10, 42);
            label11.Name = "label11";
            label11.Size = new Size(141, 25);
            label11.TabIndex = 2;
            label11.Text = "account number";
            // 
            // labelTranfer2RecvNumber
            // 
            labelTranfer2RecvNumber.AutoSize = true;
            labelTranfer2RecvNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTranfer2RecvNumber.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer2RecvNumber.Location = new Point(12, 69);
            labelTranfer2RecvNumber.Name = "labelTranfer2RecvNumber";
            labelTranfer2RecvNumber.Size = new Size(52, 25);
            labelTranfer2RecvNumber.TabIndex = 1;
            labelTranfer2RecvNumber.Text = "0000";
            // 
            // labelTranfer2RecvName
            // 
            labelTranfer2RecvName.AutoSize = true;
            labelTranfer2RecvName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTranfer2RecvName.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer2RecvName.Location = new Point(10, 10);
            labelTranfer2RecvName.Name = "labelTranfer2RecvName";
            labelTranfer2RecvName.Size = new Size(68, 28);
            labelTranfer2RecvName.TabIndex = 0;
            labelTranfer2RecvName.Text = "Name";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 235, 235);
            panel8.Controls.Add(labelTranfer2Amount);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(btnTranfer2Confirm);
            panel8.Location = new Point(2, 370);
            panel8.Name = "panel8";
            panel8.Size = new Size(352, 193);
            panel8.TabIndex = 31;
            // 
            // labelTranfer2Amount
            // 
            labelTranfer2Amount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTranfer2Amount.Location = new Point(99, 17);
            labelTranfer2Amount.Name = "labelTranfer2Amount";
            labelTranfer2Amount.Size = new Size(237, 38);
            labelTranfer2Amount.TabIndex = 31;
            labelTranfer2Amount.Text = "0000 ฿";
            labelTranfer2Amount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 25);
            label17.Name = "label17";
            label17.Size = new Size(77, 25);
            label17.TabIndex = 30;
            label17.Text = "Amount";
            // 
            // btnTranfer2Confirm
            // 
            btnTranfer2Confirm.Location = new Point(16, 107);
            btnTranfer2Confirm.Name = "btnTranfer2Confirm";
            btnTranfer2Confirm.Size = new Size(321, 34);
            btnTranfer2Confirm.TabIndex = 29;
            btnTranfer2Confirm.Text = "Confirm";
            btnTranfer2Confirm.UseVisualStyleBackColor = true;
            btnTranfer2Confirm.Click += btnTranfer2Confirm_Click;
            // 
            // btnTranfer2Cancel
            // 
            btnTranfer2Cancel.BackColor = Color.Transparent;
            btnTranfer2Cancel.FlatAppearance.BorderColor = Color.LightPink;
            btnTranfer2Cancel.FlatAppearance.BorderSize = 0;
            btnTranfer2Cancel.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnTranfer2Cancel.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnTranfer2Cancel.FlatStyle = FlatStyle.Flat;
            btnTranfer2Cancel.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTranfer2Cancel.Location = new Point(2, 0);
            btnTranfer2Cancel.Name = "btnTranfer2Cancel";
            btnTranfer2Cancel.Size = new Size(37, 49);
            btnTranfer2Cancel.TabIndex = 28;
            btnTranfer2Cancel.Text = "<";
            btnTranfer2Cancel.TextAlign = ContentAlignment.TopLeft;
            btnTranfer2Cancel.UseVisualStyleBackColor = false;
            btnTranfer2Cancel.Click += btnTranfer2Cancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 211);
            label6.Name = "label6";
            label6.Size = new Size(34, 28);
            label6.TabIndex = 27;
            label6.Text = "To";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 54);
            label9.Name = "label9";
            label9.Size = new Size(60, 28);
            label9.TabIndex = 26;
            label9.Text = "From";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.HighlightText;
            panel6.Controls.Add(labelTranfer2AccBalance);
            panel6.Controls.Add(labelTranfer2AccNumber);
            panel6.Controls.Add(labelTranfer2AccName);
            panel6.Location = new Point(11, 92);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 105);
            panel6.TabIndex = 1;
            // 
            // labelTranfer2AccBalance
            // 
            labelTranfer2AccBalance.Anchor = AnchorStyles.Right;
            labelTranfer2AccBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTranfer2AccBalance.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer2AccBalance.Location = new Point(12, 65);
            labelTranfer2AccBalance.Name = "labelTranfer2AccBalance";
            labelTranfer2AccBalance.Size = new Size(216, 29);
            labelTranfer2AccBalance.TabIndex = 3;
            labelTranfer2AccBalance.Text = "balance ฿";
            labelTranfer2AccBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTranfer2AccNumber
            // 
            labelTranfer2AccNumber.AutoSize = true;
            labelTranfer2AccNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTranfer2AccNumber.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer2AccNumber.Location = new Point(12, 39);
            labelTranfer2AccNumber.Name = "labelTranfer2AccNumber";
            labelTranfer2AccNumber.Size = new Size(52, 25);
            labelTranfer2AccNumber.TabIndex = 1;
            labelTranfer2AccNumber.Text = "0000";
            // 
            // labelTranfer2AccName
            // 
            labelTranfer2AccName.AutoSize = true;
            labelTranfer2AccName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTranfer2AccName.ForeColor = SystemColors.ActiveCaptionText;
            labelTranfer2AccName.Location = new Point(12, 11);
            labelTranfer2AccName.Name = "labelTranfer2AccName";
            labelTranfer2AccName.Size = new Size(68, 28);
            labelTranfer2AccName.TabIndex = 0;
            labelTranfer2AccName.Text = "Name";
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Desktop;
            label13.Location = new Point(93, 20);
            label13.Name = "label13";
            label13.Size = new Size(165, 32);
            label13.TabIndex = 0;
            label13.Text = "Tranfer";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelWithdrawWithoutCard1
            // 
            panelWithdrawWithoutCard1.BackColor = Color.Pink;
            panelWithdrawWithoutCard1.Controls.Add(btnWithdrawWithoutCard1Cancel);
            panelWithdrawWithoutCard1.Controls.Add(label10);
            panelWithdrawWithoutCard1.Controls.Add(label12);
            panelWithdrawWithoutCard1.Controls.Add(panel9);
            panelWithdrawWithoutCard1.Controls.Add(label18);
            panelWithdrawWithoutCard1.Controls.Add(panel10);
            panelWithdrawWithoutCard1.Location = new Point(0, 1);
            panelWithdrawWithoutCard1.Name = "panelWithdrawWithoutCard1";
            panelWithdrawWithoutCard1.Size = new Size(352, 562);
            panelWithdrawWithoutCard1.TabIndex = 29;
            // 
            // btnWithdrawWithoutCard1Cancel
            // 
            btnWithdrawWithoutCard1Cancel.BackColor = Color.Transparent;
            btnWithdrawWithoutCard1Cancel.FlatAppearance.BorderColor = Color.LightPink;
            btnWithdrawWithoutCard1Cancel.FlatAppearance.BorderSize = 0;
            btnWithdrawWithoutCard1Cancel.FlatAppearance.MouseDownBackColor = Color.LightPink;
            btnWithdrawWithoutCard1Cancel.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnWithdrawWithoutCard1Cancel.FlatStyle = FlatStyle.Flat;
            btnWithdrawWithoutCard1Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawWithoutCard1Cancel.Location = new Point(304, -1);
            btnWithdrawWithoutCard1Cancel.Name = "btnWithdrawWithoutCard1Cancel";
            btnWithdrawWithoutCard1Cancel.Size = new Size(45, 34);
            btnWithdrawWithoutCard1Cancel.TabIndex = 28;
            btnWithdrawWithoutCard1Cancel.Text = "X";
            btnWithdrawWithoutCard1Cancel.TextAlign = ContentAlignment.TopCenter;
            btnWithdrawWithoutCard1Cancel.UseVisualStyleBackColor = false;
            btnWithdrawWithoutCard1Cancel.Click += btnWithdrawWithoutCard1Cancel_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 230);
            label10.Name = "label10";
            label10.Size = new Size(180, 28);
            label10.TabIndex = 27;
            label10.Text = "Withdraw at ATM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 54);
            label12.Name = "label12";
            label12.Size = new Size(60, 28);
            label12.TabIndex = 26;
            label12.Text = "From";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.HighlightText;
            panel9.Controls.Add(labelWithdrawWithoutCard1AccBalance);
            panel9.Controls.Add(labelWithdrawWithoutCard1AccNumber);
            panel9.Controls.Add(labelWithdrawWithoutCard1AccName);
            panel9.Location = new Point(11, 92);
            panel9.Name = "panel9";
            panel9.Size = new Size(325, 119);
            panel9.TabIndex = 1;
            // 
            // labelWithdrawWithoutCard1AccBalance
            // 
            labelWithdrawWithoutCard1AccBalance.Anchor = AnchorStyles.Right;
            labelWithdrawWithoutCard1AccBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelWithdrawWithoutCard1AccBalance.ForeColor = SystemColors.ActiveCaptionText;
            labelWithdrawWithoutCard1AccBalance.Location = new Point(10, 71);
            labelWithdrawWithoutCard1AccBalance.Name = "labelWithdrawWithoutCard1AccBalance";
            labelWithdrawWithoutCard1AccBalance.Size = new Size(216, 37);
            labelWithdrawWithoutCard1AccBalance.TabIndex = 3;
            labelWithdrawWithoutCard1AccBalance.Text = "balance ฿";
            labelWithdrawWithoutCard1AccBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelWithdrawWithoutCard1AccNumber
            // 
            labelWithdrawWithoutCard1AccNumber.AutoSize = true;
            labelWithdrawWithoutCard1AccNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWithdrawWithoutCard1AccNumber.ForeColor = SystemColors.ActiveCaptionText;
            labelWithdrawWithoutCard1AccNumber.Location = new Point(12, 38);
            labelWithdrawWithoutCard1AccNumber.Name = "labelWithdrawWithoutCard1AccNumber";
            labelWithdrawWithoutCard1AccNumber.Size = new Size(52, 25);
            labelWithdrawWithoutCard1AccNumber.TabIndex = 1;
            labelWithdrawWithoutCard1AccNumber.Text = "0000";
            // 
            // labelWithdrawWithoutCard1AccName
            // 
            labelWithdrawWithoutCard1AccName.AutoSize = true;
            labelWithdrawWithoutCard1AccName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelWithdrawWithoutCard1AccName.ForeColor = SystemColors.ActiveCaptionText;
            labelWithdrawWithoutCard1AccName.Location = new Point(12, 10);
            labelWithdrawWithoutCard1AccName.Name = "labelWithdrawWithoutCard1AccName";
            labelWithdrawWithoutCard1AccName.Size = new Size(68, 28);
            labelWithdrawWithoutCard1AccName.TabIndex = 0;
            labelWithdrawWithoutCard1AccName.Text = "Name";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.Desktop;
            label18.Location = new Point(33, 20);
            label18.Name = "label18";
            label18.Size = new Size(275, 32);
            label18.TabIndex = 0;
            label18.Text = "Withdraw without Card";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(255, 235, 235);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount6);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount5);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount4);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount3);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount2);
            panel10.Controls.Add(btnWithdrawWithoutCard1Amount1);
            panel10.Controls.Add(btnWithdrawWithoutCard1Next);
            panel10.Controls.Add(textBoxWithdrawWithoutCard1Amount);
            panel10.Controls.Add(label19);
            panel10.Location = new Point(0, 263);
            panel10.Name = "panel10";
            panel10.Size = new Size(349, 299);
            panel10.TabIndex = 25;
            // 
            // btnWithdrawWithoutCard1Amount6
            // 
            btnWithdrawWithoutCard1Amount6.Location = new Point(223, 85);
            btnWithdrawWithoutCard1Amount6.Name = "btnWithdrawWithoutCard1Amount6";
            btnWithdrawWithoutCard1Amount6.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount6.TabIndex = 10;
            btnWithdrawWithoutCard1Amount6.Text = "5000";
            btnWithdrawWithoutCard1Amount6.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount6.Click += btnWithdrawWithoutCard1Amount6_Click;
            // 
            // btnWithdrawWithoutCard1Amount5
            // 
            btnWithdrawWithoutCard1Amount5.Location = new Point(128, 86);
            btnWithdrawWithoutCard1Amount5.Name = "btnWithdrawWithoutCard1Amount5";
            btnWithdrawWithoutCard1Amount5.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount5.TabIndex = 9;
            btnWithdrawWithoutCard1Amount5.Text = "3000";
            btnWithdrawWithoutCard1Amount5.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount5.Click += btnWithdrawWithoutCard1Amount5_Click;
            // 
            // btnWithdrawWithoutCard1Amount4
            // 
            btnWithdrawWithoutCard1Amount4.Location = new Point(33, 85);
            btnWithdrawWithoutCard1Amount4.Name = "btnWithdrawWithoutCard1Amount4";
            btnWithdrawWithoutCard1Amount4.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount4.TabIndex = 8;
            btnWithdrawWithoutCard1Amount4.Text = "1000";
            btnWithdrawWithoutCard1Amount4.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount4.Click += btnWithdrawWithoutCard1Amount4_Click;
            // 
            // btnWithdrawWithoutCard1Amount3
            // 
            btnWithdrawWithoutCard1Amount3.Location = new Point(223, 41);
            btnWithdrawWithoutCard1Amount3.Name = "btnWithdrawWithoutCard1Amount3";
            btnWithdrawWithoutCard1Amount3.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount3.TabIndex = 7;
            btnWithdrawWithoutCard1Amount3.Text = "500";
            btnWithdrawWithoutCard1Amount3.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount3.Click += btnWithdrawWithoutCard1Amount3_Click;
            // 
            // btnWithdrawWithoutCard1Amount2
            // 
            btnWithdrawWithoutCard1Amount2.Location = new Point(128, 42);
            btnWithdrawWithoutCard1Amount2.Name = "btnWithdrawWithoutCard1Amount2";
            btnWithdrawWithoutCard1Amount2.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount2.TabIndex = 6;
            btnWithdrawWithoutCard1Amount2.Text = "200";
            btnWithdrawWithoutCard1Amount2.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount2.Click += btnWithdrawWithoutCard1Amount2_Click;
            // 
            // btnWithdrawWithoutCard1Amount1
            // 
            btnWithdrawWithoutCard1Amount1.Location = new Point(33, 41);
            btnWithdrawWithoutCard1Amount1.Name = "btnWithdrawWithoutCard1Amount1";
            btnWithdrawWithoutCard1Amount1.Size = new Size(89, 34);
            btnWithdrawWithoutCard1Amount1.TabIndex = 5;
            btnWithdrawWithoutCard1Amount1.Text = "100";
            btnWithdrawWithoutCard1Amount1.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Amount1.Click += btnWithdrawWithoutCard1Amount1_Click;
            // 
            // btnWithdrawWithoutCard1Next
            // 
            btnWithdrawWithoutCard1Next.Location = new Point(11, 185);
            btnWithdrawWithoutCard1Next.Name = "btnWithdrawWithoutCard1Next";
            btnWithdrawWithoutCard1Next.Size = new Size(321, 34);
            btnWithdrawWithoutCard1Next.TabIndex = 4;
            btnWithdrawWithoutCard1Next.Text = "Next";
            btnWithdrawWithoutCard1Next.UseVisualStyleBackColor = true;
            btnWithdrawWithoutCard1Next.Click += btnWithdrawWithoutCard1Next_Click;
            // 
            // textBoxWithdrawWithoutCard1Amount
            // 
            textBoxWithdrawWithoutCard1Amount.Location = new Point(12, 133);
            textBoxWithdrawWithoutCard1Amount.Name = "textBoxWithdrawWithoutCard1Amount";
            textBoxWithdrawWithoutCard1Amount.Size = new Size(319, 31);
            textBoxWithdrawWithoutCard1Amount.TabIndex = 3;
            textBoxWithdrawWithoutCard1Amount.TextAlign = HorizontalAlignment.Right;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 8);
            label19.Name = "label19";
            label19.Size = new Size(77, 25);
            label19.TabIndex = 2;
            label19.Text = "Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 235, 235);
            ClientSize = new Size(349, 560);
            Controls.Add(panelMain);
            Controls.Add(panelWithdrawWithoutCard1);
            Controls.Add(panelTranfer2);
            Controls.Add(panelTranfer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelTranfer1.ResumeLayout(false);
            panelTranfer1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelTranfer2.ResumeLayout(false);
            panelTranfer2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelWithdrawWithoutCard1.ResumeLayout(false);
            panelWithdrawWithoutCard1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelAccName;
        private Label labelBalance;
        private Label label2;
        private Label labelAccNumber;
        private Button btnWithdrawWithoutCard;
        private Button btnTranfer;
        private Panel panel2;
        private Panel panelMain;
        private Panel panelTranfer1;
        private Panel panel4;
        private Label labelTranfer1Balance;
        private Label labelTranfer1AccNumber;
        private Label labelTranfer1AccName;
        private Label label7;
        private Panel panel5;
        private Label label8;
        private Label label4;
        private TextBox textBoxTranfer1RecvNumber;
        private Label label3;
        private TextBox textBoxTranfer1Amount;
        private Label label5;
        private Button btnTranfer1Next;
        private Button btnTranfer1Cancel;
        private Panel panelTranfer2;
        private Button btnTranfer2Cancel;
        private Label label6;
        private Label label9;
        private Panel panel6;
        private Label labelTranfer2AccBalance;
        private Label labelTranfer2AccNumber;
        private Label labelTranfer2AccName;
        private Label label13;
        private Panel panel7;
        private Label labelTranfer2RecvNumber;
        private Label labelTranfer2RecvName;
        private Button btnTranfer2Confirm;
        private Label label11;
        private Panel panel8;
        private Label labelTranfer2Amount;
        private Label label17;
        private Panel panelWithdrawWithoutCard1;
        private Button btnWithdrawWithoutCard1Cancel;
        private Label label10;
        private Label label12;
        private Panel panel9;
        private Label labelWithdrawWithoutCard1AccBalance;
        private Label labelWithdrawWithoutCard1AccNumber;
        private Label labelWithdrawWithoutCard1AccName;
        private Label label18;
        private Panel panel10;
        private Button btnWithdrawWithoutCard1Amount6;
        private Button btnWithdrawWithoutCard1Amount5;
        private Button btnWithdrawWithoutCard1Amount4;
        private Button btnWithdrawWithoutCard1Amount3;
        private Button btnWithdrawWithoutCard1Amount2;
        private Button btnWithdrawWithoutCard1Amount1;
        private Button btnWithdrawWithoutCard1Next;
        private TextBox textBoxWithdrawWithoutCard1Amount;
        private Label label19;
        private PictureBox pictureBoxRefresh;
    }
}
