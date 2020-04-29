/*********************************************************************************************
 * Tento súbor je súčasťou projektu Kalkulačka IVS.
 *
 * Tento program je slobodný softvér: môžete ho šíriť a upravovať podľa
 * ustanovení Všeobecnej verejnej licencie GNU (GNU General Public Licence),
 * vydávanej nadáciou Free Software Foundation a to buď podľa 3. verzie
 * tejto Licencie, alebo (podľa vášho uváženia) ktorejkoľvek neskoršej verzie. 
 * 
 * Tento program je rozširovaný v nádeji, že bude užitočný, avšak BEZ AKEJKOĽVEK ZÁRUKY.
 * Neposkytujú sa ani odvodené záruky PREDAJNOSTI alebo VHODNOSTI PRE URČITÝ ÚČEL.
 * Ďalšie podrobnosti hľadajte vo Všeobecnej verejne licencii GNU.
 *
 * Kópiu Všeobecnej verejnej licencie GNU ste mali dostať spolu s týmto programom.
 * Ak sa tak nestalo, nájdete ju tu: <http://www.gnu.org/licenses/>. 
 **********************************************************************************************/


/**********************************************************************************************
 * Názov projektu: Kalkulačka IVS
 * Súbor: Form1.Designer.cs
 * Dátum: 18.04.2020
 * Posledná zmena: 18.04.2020
 * Autor: Andrej Hýroš - xhyros00
 * Popis: Súbor inicializácie komponentov
 * ********************************************************************************************/
/**
 * @file Form1.Designer.cs
 * @brief Súbor inicializácie komponentov
 * @author Andrej Hýroš
 */

namespace IVS_Calc_v01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberOne = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.numberNine = new System.Windows.Forms.Button();
            this.numberZero = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.coma = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.powerOf = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOne
            // 
            this.numberOne.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberOne.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOne.Location = new System.Drawing.Point(12, 79);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(50, 51);
            this.numberOne.TabIndex = 0;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = false;
            this.numberOne.Click += new System.EventHandler(this.numClick);
            // 
            // numberTwo
            // 
            this.numberTwo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberTwo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberTwo.Location = new System.Drawing.Point(68, 79);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(50, 50);
            this.numberTwo.TabIndex = 1;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = false;
            this.numberTwo.Click += new System.EventHandler(this.numClick);
            // 
            // numberFive
            // 
            this.numberFive.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberFive.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberFive.Location = new System.Drawing.Point(68, 135);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(50, 50);
            this.numberFive.TabIndex = 2;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = false;
            this.numberFive.Click += new System.EventHandler(this.numClick);
            // 
            // numberFour
            // 
            this.numberFour.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberFour.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberFour.Location = new System.Drawing.Point(12, 135);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(50, 50);
            this.numberFour.TabIndex = 3;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = false;
            this.numberFour.Click += new System.EventHandler(this.numClick);
            // 
            // numberThree
            // 
            this.numberThree.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberThree.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberThree.Location = new System.Drawing.Point(124, 79);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(50, 50);
            this.numberThree.TabIndex = 4;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = false;
            this.numberThree.Click += new System.EventHandler(this.numClick);
            // 
            // numberSix
            // 
            this.numberSix.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberSix.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberSix.Location = new System.Drawing.Point(124, 135);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(50, 50);
            this.numberSix.TabIndex = 5;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = false;
            this.numberSix.Click += new System.EventHandler(this.numClick);
            // 
            // numberSeven
            // 
            this.numberSeven.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberSeven.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberSeven.Location = new System.Drawing.Point(12, 191);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(50, 50);
            this.numberSeven.TabIndex = 6;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = false;
            this.numberSeven.Click += new System.EventHandler(this.numClick);
            // 
            // numberNine
            // 
            this.numberNine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberNine.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberNine.Location = new System.Drawing.Point(124, 191);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(50, 50);
            this.numberNine.TabIndex = 7;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = false;
            this.numberNine.Click += new System.EventHandler(this.numClick);
            // 
            // numberZero
            // 
            this.numberZero.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberZero.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberZero.Location = new System.Drawing.Point(12, 247);
            this.numberZero.Name = "numberZero";
            this.numberZero.Size = new System.Drawing.Size(50, 50);
            this.numberZero.TabIndex = 8;
            this.numberZero.Text = "0";
            this.numberZero.UseVisualStyleBackColor = false;
            this.numberZero.Click += new System.EventHandler(this.numClick);
            // 
            // numberEight
            // 
            this.numberEight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numberEight.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberEight.Location = new System.Drawing.Point(68, 191);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(50, 50);
            this.numberEight.TabIndex = 9;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = false;
            this.numberEight.Click += new System.EventHandler(this.numClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(180, 79);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 50);
            this.add.TabIndex = 10;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.opClick);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mul.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mul.Location = new System.Drawing.Point(180, 191);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(50, 50);
            this.mul.TabIndex = 11;
            this.mul.Text = "×";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.opClick);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sub.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sub.Location = new System.Drawing.Point(180, 135);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(50, 50);
            this.sub.TabIndex = 12;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.opClick);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.div.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.div.Location = new System.Drawing.Point(180, 247);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(50, 50);
            this.div.TabIndex = 13;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.opClick);
            // 
            // coma
            // 
            this.coma.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.coma.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coma.Location = new System.Drawing.Point(124, 247);
            this.coma.Name = "coma";
            this.coma.Size = new System.Drawing.Size(50, 50);
            this.coma.TabIndex = 14;
            this.coma.Text = ".";
            this.coma.UseVisualStyleBackColor = false;
            this.coma.Click += new System.EventHandler(this.numClick);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clear.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.Location = new System.Drawing.Point(68, 247);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(50, 50);
            this.clear.TabIndex = 15;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // powerOf
            // 
            this.powerOf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.powerOf.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.powerOf.Location = new System.Drawing.Point(236, 79);
            this.powerOf.Name = "powerOf";
            this.powerOf.Size = new System.Drawing.Size(50, 50);
            this.powerOf.TabIndex = 16;
            this.powerOf.Text = "(x)ʸ";
            this.powerOf.UseVisualStyleBackColor = false;
            this.powerOf.Click += new System.EventHandler(this.opClick);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sqrt.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrt.Location = new System.Drawing.Point(236, 135);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(50, 50);
            this.sqrt.TabIndex = 17;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.opClick);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.factorial.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.factorial.Location = new System.Drawing.Point(236, 191);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(50, 50);
            this.factorial.TabIndex = 18;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.opClick);
            // 
            // abs
            // 
            this.abs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.abs.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.abs.Location = new System.Drawing.Point(236, 247);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(50, 50);
            this.abs.TabIndex = 19;
            this.abs.Text = "|x|";
            this.abs.UseVisualStyleBackColor = false;
            this.abs.Click += new System.EventHandler(this.opClick);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equal.Location = new System.Drawing.Point(181, 303);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(105, 50);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.eqClick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(12, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(274, 39);
            this.textBox.TabIndex = 21;
            this.textBox.Text = "0";
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.help.Cursor = System.Windows.Forms.Cursors.Help;
            this.help.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.help.Location = new System.Drawing.Point(124, 303);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(50, 50);
            this.help.TabIndex = 22;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(297, 394);
            this.Controls.Add(this.help);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.abs);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.powerOf);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.coma);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.add);
            this.Controls.Add(this.numberEight);
            this.Controls.Add(this.numberZero);
            this.Controls.Add(this.numberNine);
            this.Controls.Add(this.numberSeven);
            this.Controls.Add(this.numberSix);
            this.Controls.Add(this.numberThree);
            this.Controls.Add(this.numberFour);
            this.Controls.Add(this.numberFive);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulačka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button numberZero;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button coma;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button powerOf;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button help;
    }
}

