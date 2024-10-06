namespace AbstractFactory
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
            factoryComboBox = new ComboBox();
            drawButton = new Button();
            drawingPanel = new Panel();
            SuspendLayout();
            // 
            // factoryComboBox
            // 
            factoryComboBox.FormattingEnabled = true;
            factoryComboBox.Location = new Point(12, 12);
            factoryComboBox.Name = "factoryComboBox";
            factoryComboBox.Size = new Size(150, 28);
            factoryComboBox.TabIndex = 0;
            // 
            // drawButton
            // 
            drawButton.Location = new Point(180, 10);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(75, 34);
            drawButton.TabIndex = 1;
            drawButton.Text = "Draw";
            drawButton.UseVisualStyleBackColor = true;
            drawButton.Click += drawButton_Click;
            // 
            // drawingPanel
            // 
            drawingPanel.Location = new Point(12, 50);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(360, 200);
            drawingPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 214);
            Controls.Add(drawingPanel);
            Controls.Add(drawButton);
            Controls.Add(factoryComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox factoryComboBox;
        private Button drawButton;
        private Panel drawingPanel;
    }
}
