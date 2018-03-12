namespace GalaxyCinemas
{
    partial class ExportDataForm
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
            this.btnSelectExportMovies = new System.Windows.Forms.Button();
            this.btnExportMoviesStart = new System.Windows.Forms.Button();
            this.btnMovieExportStop = new System.Windows.Forms.Button();
            this.txtFileMovie = new System.Windows.Forms.TextBox();
            this.btnSelectExportSessions = new System.Windows.Forms.Button();
            this.btnExportSessionsStart = new System.Windows.Forms.Button();
            this.btnExportSessionStop = new System.Windows.Forms.Button();
            this.txtFileSession = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtFileBooking = new System.Windows.Forms.TextBox();
            this.btnSelectExportBooking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnExportBookings = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectExportMovies
            // 
            this.btnSelectExportMovies.Location = new System.Drawing.Point(38, 381);
            this.btnSelectExportMovies.Name = "btnSelectExportMovies";
            this.btnSelectExportMovies.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportMovies.TabIndex = 0;
            this.btnSelectExportMovies.Text = "Select File for Exporting Movies";
            this.btnSelectExportMovies.UseVisualStyleBackColor = true;
            this.btnSelectExportMovies.Visible = false;
            // 
            // btnExportMoviesStart
            // 
            this.btnExportMoviesStart.Location = new System.Drawing.Point(38, 436);
            this.btnExportMoviesStart.Name = "btnExportMoviesStart";
            this.btnExportMoviesStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportMoviesStart.TabIndex = 1;
            this.btnExportMoviesStart.Text = "Start";
            this.btnExportMoviesStart.UseVisualStyleBackColor = true;
            this.btnExportMoviesStart.Visible = false;
            // 
            // btnMovieExportStop
            // 
            this.btnMovieExportStop.Location = new System.Drawing.Point(38, 436);
            this.btnMovieExportStop.Name = "btnMovieExportStop";
            this.btnMovieExportStop.Size = new System.Drawing.Size(75, 23);
            this.btnMovieExportStop.TabIndex = 2;
            this.btnMovieExportStop.Text = "Stop";
            this.btnMovieExportStop.UseVisualStyleBackColor = true;
            this.btnMovieExportStop.Visible = false;
            // 
            // txtFileMovie
            // 
            this.txtFileMovie.Location = new System.Drawing.Point(38, 410);
            this.txtFileMovie.Name = "txtFileMovie";
            this.txtFileMovie.Size = new System.Drawing.Size(242, 20);
            this.txtFileMovie.TabIndex = 3;
            this.txtFileMovie.Visible = false;
            // 
            // btnSelectExportSessions
            // 
            this.btnSelectExportSessions.Location = new System.Drawing.Point(38, 498);
            this.btnSelectExportSessions.Name = "btnSelectExportSessions";
            this.btnSelectExportSessions.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportSessions.TabIndex = 4;
            this.btnSelectExportSessions.Text = "Select File for Exporting Sessions";
            this.btnSelectExportSessions.UseVisualStyleBackColor = true;
            this.btnSelectExportSessions.Visible = false;
            // 
            // btnExportSessionsStart
            // 
            this.btnExportSessionsStart.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionsStart.Name = "btnExportSessionsStart";
            this.btnExportSessionsStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionsStart.TabIndex = 5;
            this.btnExportSessionsStart.Text = "Start";
            this.btnExportSessionsStart.UseVisualStyleBackColor = true;
            this.btnExportSessionsStart.Visible = false;
            // 
            // btnExportSessionStop
            // 
            this.btnExportSessionStop.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionStop.Name = "btnExportSessionStop";
            this.btnExportSessionStop.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionStop.TabIndex = 6;
            this.btnExportSessionStop.Text = "Stop";
            this.btnExportSessionStop.UseVisualStyleBackColor = true;
            this.btnExportSessionStop.Visible = false;
            // 
            // txtFileSession
            // 
            this.txtFileSession.Location = new System.Drawing.Point(38, 527);
            this.txtFileSession.Name = "txtFileSession";
            this.txtFileSession.Size = new System.Drawing.Size(242, 20);
            this.txtFileSession.TabIndex = 7;
            this.txtFileSession.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 527);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML|*.xml";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 25);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(79, 13);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Save Location:";
            // 
            // txtFileBooking
            // 
            this.txtFileBooking.Location = new System.Drawing.Point(95, 25);
            this.txtFileBooking.Name = "txtFileBooking";
            this.txtFileBooking.Size = new System.Drawing.Size(381, 20);
            this.txtFileBooking.TabIndex = 11;
            // 
            // btnSelectExportBooking
            // 
            this.btnSelectExportBooking.Location = new System.Drawing.Point(516, 25);
            this.btnSelectExportBooking.Name = "btnSelectExportBooking";
            this.btnSelectExportBooking.Size = new System.Drawing.Size(75, 23);
            this.btnSelectExportBooking.TabIndex = 12;
            this.btnSelectExportBooking.Text = "Browse";
            this.btnSelectExportBooking.UseVisualStyleBackColor = true;
            this.btnSelectExportBooking.Click += new System.EventHandler(this.btnSelectExportBooking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(95, 81);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 15;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(342, 81);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 16;
            // 
            // btnExportBookings
            // 
            this.btnExportBookings.Location = new System.Drawing.Point(477, 133);
            this.btnExportBookings.Name = "btnExportBookings";
            this.btnExportBookings.Size = new System.Drawing.Size(114, 23);
            this.btnExportBookings.TabIndex = 17;
            this.btnExportBookings.Text = "Export Bookings";
            this.btnExportBookings.UseVisualStyleBackColor = true;
            this.btnExportBookings.Click += new System.EventHandler(this.btnExportBookings_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(516, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(624, 259);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExportBookings);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectExportBooking);
            this.Controls.Add(this.txtFileBooking);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFileSession);
            this.Controls.Add(this.btnExportSessionStop);
            this.Controls.Add(this.btnExportSessionsStart);
            this.Controls.Add(this.btnSelectExportSessions);
            this.Controls.Add(this.txtFileMovie);
            this.Controls.Add(this.btnMovieExportStop);
            this.Controls.Add(this.btnExportMoviesStart);
            this.Controls.Add(this.btnSelectExportMovies);
            this.Name = "ExportDataForm";
            this.Text = "Export Data";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectExportMovies;
        private System.Windows.Forms.Button btnExportMoviesStart;
        private System.Windows.Forms.Button btnMovieExportStop;
        private System.Windows.Forms.TextBox txtFileMovie;
        private System.Windows.Forms.Button btnSelectExportSessions;
        private System.Windows.Forms.Button btnExportSessionsStart;
        private System.Windows.Forms.Button btnExportSessionStop;
        private System.Windows.Forms.TextBox txtFileSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExportBookings;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectExportBooking;
        private System.Windows.Forms.TextBox txtFileBooking;
        private System.Windows.Forms.Label lblLocation;
    }
}