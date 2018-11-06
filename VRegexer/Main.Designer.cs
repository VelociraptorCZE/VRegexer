namespace VRegexer
{
    partial class VRegexer
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRegexer));
            this.regexInput = new System.Windows.Forms.TextBox();
            this.testStringInput = new System.Windows.Forms.TextBox();
            this.resultsOutput = new System.Windows.Forms.TextBox();
            this.patternLbl = new System.Windows.Forms.Label();
            this.testStringLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // regexInput
            // 
            resources.ApplyResources(this.regexInput, "regexInput");
            this.regexInput.Name = "regexInput";
            this.regexInput.TextChanged += new System.EventHandler(this.RegexInputOnChange);
            // 
            // testStringInput
            // 
            resources.ApplyResources(this.testStringInput, "testStringInput");
            this.testStringInput.Name = "testStringInput";
            this.testStringInput.TextChanged += new System.EventHandler(this.TestStringInputOnChange);
            // 
            // resultsOutput
            // 
            resources.ApplyResources(this.resultsOutput, "resultsOutput");
            this.resultsOutput.Name = "resultsOutput";
            this.resultsOutput.ReadOnly = true;
            // 
            // patternLbl
            // 
            resources.ApplyResources(this.patternLbl, "patternLbl");
            this.patternLbl.Name = "patternLbl";
            // 
            // testStringLbl
            // 
            resources.ApplyResources(this.testStringLbl, "testStringLbl");
            this.testStringLbl.Name = "testStringLbl";
            // 
            // outputLbl
            // 
            resources.ApplyResources(this.outputLbl, "outputLbl");
            this.outputLbl.Name = "outputLbl";
            // 
            // VRegexer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.testStringLbl);
            this.Controls.Add(this.patternLbl);
            this.Controls.Add(this.resultsOutput);
            this.Controls.Add(this.testStringInput);
            this.Controls.Add(this.regexInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VRegexer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox regexInput;
        private System.Windows.Forms.TextBox testStringInput;
        private  System.Windows.Forms.TextBox resultsOutput;
        private System.Windows.Forms.Label patternLbl;
        private System.Windows.Forms.Label testStringLbl;
        private System.Windows.Forms.Label outputLbl;
    }
}

