namespace XMLPostForm {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblButtonText = new System.Windows.Forms.Label();
            this.btnPostUrbanScienceADFXML = new System.Windows.Forms.Button();
            this.txtAdfXml = new System.Windows.Forms.TextBox();
            this.cboTestAdfXml = new System.Windows.Forms.ComboBox();
            this.cboEnvironmentSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblButtonText
            // 
            this.lblButtonText.AutoSize = true;
            this.lblButtonText.Location = new System.Drawing.Point(226, 9);
            this.lblButtonText.Name = "lblButtonText";
            this.lblButtonText.Size = new System.Drawing.Size(120, 13);
            this.lblButtonText.TabIndex = 0;
            this.lblButtonText.Text = "Press to send XML Test";
            // 
            // btnPostUrbanScienceADFXML
            // 
            this.btnPostUrbanScienceADFXML.Location = new System.Drawing.Point(204, 25);
            this.btnPostUrbanScienceADFXML.Name = "btnPostUrbanScienceADFXML";
            this.btnPostUrbanScienceADFXML.Size = new System.Drawing.Size(168, 23);
            this.btnPostUrbanScienceADFXML.TabIndex = 6;
            this.btnPostUrbanScienceADFXML.Text = "POST ADF XML";
            this.btnPostUrbanScienceADFXML.UseVisualStyleBackColor = true;
            this.btnPostUrbanScienceADFXML.Click += new System.EventHandler(this.btnPostADFXMLLocal_Click);
            // 
            // txtAdfXml
            // 
            this.txtAdfXml.Location = new System.Drawing.Point(12, 169);
            this.txtAdfXml.Multiline = true;
            this.txtAdfXml.Name = "txtAdfXml";
            this.txtAdfXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdfXml.Size = new System.Drawing.Size(560, 580);
            this.txtAdfXml.TabIndex = 12;
            // 
            // cboTestAdfXml
            // 
            this.cboTestAdfXml.FormattingEnabled = true;
            this.cboTestAdfXml.Location = new System.Drawing.Point(12, 142);
            this.cboTestAdfXml.Name = "cboTestAdfXml";
            this.cboTestAdfXml.Size = new System.Drawing.Size(250, 21);
            this.cboTestAdfXml.TabIndex = 13;
            this.cboTestAdfXml.SelectedIndexChanged += new System.EventHandler(this.cboTestAdfXml_SelectedIndexChanged);
            // 
            // cboEnvironmentSelection
            // 
            this.cboEnvironmentSelection.FormattingEnabled = true;
            this.cboEnvironmentSelection.Location = new System.Drawing.Point(12, 102);
            this.cboEnvironmentSelection.Name = "cboEnvironmentSelection";
            this.cboEnvironmentSelection.Size = new System.Drawing.Size(560, 21);
            this.cboEnvironmentSelection.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Environment to Post Lead";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Test Lead to Post";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEnvironmentSelection);
            this.Controls.Add(this.cboTestAdfXml);
            this.Controls.Add(this.txtAdfXml);
            this.Controls.Add(this.btnPostUrbanScienceADFXML);
            this.Controls.Add(this.lblButtonText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblButtonText;
        private System.Windows.Forms.Button btnPostUrbanScienceADFXML;
        private System.Windows.Forms.TextBox txtAdfXml;
        private System.Windows.Forms.ComboBox cboTestAdfXml;
        private System.Windows.Forms.ComboBox cboEnvironmentSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

