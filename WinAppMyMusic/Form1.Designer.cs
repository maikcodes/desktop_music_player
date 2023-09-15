namespace WinAppMyMusic
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBMusica = new System.Windows.Forms.ListBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.mcTrackBarTiempo = new XComponent.SliderBar.MACTrackBar();
            this.macTrackBar1 = new XComponent.SliderBar.MACTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStop = new FontAwesome.Sharp.IconButton();
            this.BtnAnterior = new FontAwesome.Sharp.IconButton();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.pbxAnterior = new System.Windows.Forms.PictureBox();
            this.pbxSiguiente = new System.Windows.Forms.PictureBox();
            this.pbxCaratula = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaratula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBMusica
            // 
            this.ListBMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.ListBMusica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListBMusica.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBMusica.ForeColor = System.Drawing.Color.White;
            this.ListBMusica.FormattingEnabled = true;
            this.ListBMusica.ItemHeight = 18;
            this.ListBMusica.Location = new System.Drawing.Point(0, 374);
            this.ListBMusica.Name = "ListBMusica";
            this.ListBMusica.Size = new System.Drawing.Size(731, 76);
            this.ListBMusica.TabIndex = 4;
            this.ListBMusica.SelectedIndexChanged += new System.EventHandler(this.ListBMusica_SelectedIndexChanged);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = global::WinAppMyMusic.Properties.Resources.circle_more_plus_icon_1320183136549593898;
            this.pbxAdd.Location = new System.Drawing.Point(693, 326);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(38, 35);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAdd.TabIndex = 4;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.ForeColor = System.Drawing.Color.White;
            this.LblDescription.Location = new System.Drawing.Point(13, 334);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(18, 18);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "--";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(12, 305);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(29, 20);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "----";
            // 
            // Reproductor
            // 
            this.Reproductor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(0, 0);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(731, 24);
            this.Reproductor.TabIndex = 17;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // mcTrackBarTiempo
            // 
            this.mcTrackBarTiempo.BackColor = System.Drawing.Color.Transparent;
            this.mcTrackBarTiempo.BorderColor = System.Drawing.Color.Transparent;
            this.mcTrackBarTiempo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcTrackBarTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(157)))), ((int)(((byte)(172)))));
            this.mcTrackBarTiempo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mcTrackBarTiempo.IndentHeight = 6;
            this.mcTrackBarTiempo.Location = new System.Drawing.Point(166, 215);
            this.mcTrackBarTiempo.Maximum = 100;
            this.mcTrackBarTiempo.Minimum = 0;
            this.mcTrackBarTiempo.Name = "mcTrackBarTiempo";
            this.mcTrackBarTiempo.Size = new System.Drawing.Size(399, 22);
            this.mcTrackBarTiempo.TabIndex = 18;
            this.mcTrackBarTiempo.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mcTrackBarTiempo.TickColor = System.Drawing.Color.DimGray;
            this.mcTrackBarTiempo.TickHeight = 4;
            this.mcTrackBarTiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mcTrackBarTiempo.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(144)))), ((int)(((byte)(159)))));
            this.mcTrackBarTiempo.TrackerSize = new System.Drawing.Size(10, 10);
            this.mcTrackBarTiempo.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(157)))), ((int)(((byte)(172)))));
            this.mcTrackBarTiempo.TrackLineHeight = 3;
            this.mcTrackBarTiempo.TrackLineSelectedColor = System.Drawing.Color.MintCream;
            this.mcTrackBarTiempo.Value = 0;
            this.mcTrackBarTiempo.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mcTrackBarTiempo_ValueChanged);
            // 
            // macTrackBar1
            // 
            this.macTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.macTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.macTrackBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.macTrackBar1.IndentHeight = 6;
            this.macTrackBar1.Location = new System.Drawing.Point(339, 18);
            this.macTrackBar1.Maximum = 100;
            this.macTrackBar1.Minimum = 0;
            this.macTrackBar1.Name = "macTrackBar1";
            this.macTrackBar1.Size = new System.Drawing.Size(78, 22);
            this.macTrackBar1.TabIndex = 22;
            this.macTrackBar1.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.macTrackBar1.TickHeight = 4;
            this.macTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.macTrackBar1.TrackerColor = System.Drawing.Color.White;
            this.macTrackBar1.TrackerSize = new System.Drawing.Size(10, 10);
            this.macTrackBar1.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.macTrackBar1.TrackLineHeight = 3;
            this.macTrackBar1.TrackLineSelectedColor = System.Drawing.Color.MintCream;
            this.macTrackBar1.Value = 0;
            this.macTrackBar1.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.macTrackBar1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppMyMusic.Properties.Resources.voice;
            this.pictureBox1.Location = new System.Drawing.Point(309, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            this.btnStop.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStop.IconSize = 30;
            this.btnStop.Location = new System.Drawing.Point(123, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 23);
            this.btnStop.TabIndex = 23;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAnterior.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.BtnAnterior.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAnterior.IconSize = 30;
            this.BtnAnterior.Location = new System.Drawing.Point(164, 14);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(34, 30);
            this.BtnAnterior.TabIndex = 21;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.btnSiguiente.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 30;
            this.btnSiguiente.Location = new System.Drawing.Point(242, 13);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(29, 30);
            this.btnSiguiente.TabIndex = 20;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.IconSize = 30;
            this.btnPlay.Location = new System.Drawing.Point(210, 14);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(25, 30);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbxAnterior
            // 
            this.pbxAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAnterior.Location = new System.Drawing.Point(185, 80);
            this.pbxAnterior.Name = "pbxAnterior";
            this.pbxAnterior.Size = new System.Drawing.Size(94, 84);
            this.pbxAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAnterior.TabIndex = 16;
            this.pbxAnterior.TabStop = false;
            // 
            // pbxSiguiente
            // 
            this.pbxSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxSiguiente.Location = new System.Drawing.Point(452, 80);
            this.pbxSiguiente.Name = "pbxSiguiente";
            this.pbxSiguiente.Size = new System.Drawing.Size(100, 84);
            this.pbxSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSiguiente.TabIndex = 15;
            this.pbxSiguiente.TabStop = false;
            this.pbxSiguiente.Click += new System.EventHandler(this.pbxSiguiente_Click);
            // 
            // pbxCaratula
            // 
            this.pbxCaratula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCaratula.Location = new System.Drawing.Point(285, 49);
            this.pbxCaratula.Name = "pbxCaratula";
            this.pbxCaratula.Size = new System.Drawing.Size(162, 143);
            this.pbxCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCaratula.TabIndex = 14;
            this.pbxCaratula.TabStop = false;
            this.pbxCaratula.Click += new System.EventHandler(this.pbxCaratula_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 30);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(61, 16);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(46, 30);
            this.iconButton2.TabIndex = 25;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.BtnAnterior);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.macTrackBar1);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(154, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 55);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mcTrackBarTiempo);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.pbxAnterior);
            this.Controls.Add(this.pbxSiguiente);
            this.Controls.Add(this.pbxCaratula);
            this.Controls.Add(this.ListBMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAnterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCaratula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBMusica;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox pbxAnterior;
        private System.Windows.Forms.PictureBox pbxSiguiente;
        private System.Windows.Forms.PictureBox pbxCaratula;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox pbxAdd;
        private XComponent.SliderBar.MACTrackBar mcTrackBarTiempo;
        private FontAwesome.Sharp.IconButton btnPlay;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton BtnAnterior;
        private XComponent.SliderBar.MACTrackBar macTrackBar1;
        private FontAwesome.Sharp.IconButton btnStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

