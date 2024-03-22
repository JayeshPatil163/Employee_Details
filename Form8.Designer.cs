namespace Employee_Details;

partial class Form8
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.Emi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Yna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // pass2
            // 
            this.pass2.BackColor = System.Drawing.Color.White;
            this.pass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pass2.Location = new System.Drawing.Point(250, 598);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(397, 22);
            this.pass2.TabIndex = 30;
            this.pass2.Text = "Re-enter password";
            this.pass2.Click += new System.EventHandler(this.textBox4_Click);
            this.pass2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pass.Location = new System.Drawing.Point(250, 527);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(397, 22);
            this.pass.TabIndex = 29;
            this.pass.Text = "Password";
            this.pass.Click += new System.EventHandler(this.textBox3_Click);
            this.pass.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // Emi
            // 
            this.Emi.BackColor = System.Drawing.Color.White;
            this.Emi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Emi.Location = new System.Drawing.Point(250, 452);
            this.Emi.Name = "Emi";
            this.Emi.Size = new System.Drawing.Size(397, 22);
            this.Emi.TabIndex = 28;
            this.Emi.Text = "Admin ID";
            this.Emi.Click += new System.EventHandler(this.textBox2_Click);
            this.Emi.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(386, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yna
            // 
            this.Yna.BackColor = System.Drawing.Color.White;
            this.Yna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Yna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Yna.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yna.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Yna.Location = new System.Drawing.Point(250, 379);
            this.Yna.Name = "Yna";
            this.Yna.Size = new System.Drawing.Size(397, 22);
            this.Yna.TabIndex = 24;
            this.Yna.Text = "Your name";
            this.Yna.Click += new System.EventHandler(this.textBox1_Click);
            this.Yna.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Yna.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(375, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Log in info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "ADMIN LOGIN INFORMATION";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(1294, 824);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "Go to previous page";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Employee_Details.Properties.Resources.Untitled_6;
            this.ClientSize = new System.Drawing.Size(1600, 992);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.Emi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Yna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox pass2;
    private TextBox pass;
    private TextBox Emi;
    private Button button1;
    private TextBox Yna;
    private Label label2;
    private Label label1;
    private ErrorProvider errorProvider1;
    private ErrorProvider errorProvider2;
    private ErrorProvider errorProvider3;
    private ErrorProvider errorProvider4;
    private Label label12;
}
