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
 * Súbor: Form1.cs
 * Dátum: 18.04.2020
 * Posledná zmena: 18.04.2020
 * Autor: Andrej Hýroš - xhyros00
 * Popis: Hlavný súbor aplikácie
 * ********************************************************************************************/
/**
 * @file Form1.cs
 * @brief Hlavný súbor aplikácie
 * @author Andrej Hýroš 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
//using calclibrary;
using ClassLibrary_IVS;


namespace IVS_Calc_v01
{
    /**
     * @class Obsahuje metódy a udalosťami spúšťané funkcie slúžiace na interakciu s kalkulačkou
     */
    public partial class Form1 : Form
    {
        //desatinny operator = true
        bool isDecimal = false;

        bool mathError = false;

        //zadana operacia = true
        bool opPerformed = false;

        //stlacene =
        bool eqClicked = false;
        double result = 0;

        //prazdny string na ulozenie operatora
        string op = "";
        string mE = "Math Error";

        bool parsed = false;
         
        /**
         * Inicializuje okno kalkulačky
         * */
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Funkcia vypise "Math Error" do textoveho okna a nastaví mathError
         */
        private void mathErr()
        {
            textBox.Text = mE;
            mathError = true;
        }

        /**
         * Funkcia vypise "Syntax Error" do textového okna a nastaví mathError
         */
        private void syntErr()
        {
            textBox.Text = "Syntax Error";
            mathError = true;
        }

        //ciselne tlacidla a desatinna ciarka budu stlacitelne
        /**
         * Funkcia umožní stláčať tlačidlá čísel a desatinnej čiarky
         */
        private void valuesEnabled()
        {
            numberZero.Enabled = true;
            numberOne.Enabled = true;
            numberTwo.Enabled = true;
            numberThree.Enabled = true;
            numberFour.Enabled = true;
            numberFive.Enabled = true;
            numberSix.Enabled = true;
            numberSeven.Enabled = true;
            numberEight.Enabled = true;
            numberNine.Enabled = true;
            coma.Enabled = true;
        }

        //ciselne tlacidla a desatinna ciarka nebudu stlacitelne
        /**
         * Funkcia zabráni stláčať tlačidlá čísel a desatinnej čiarky
         */
        private void valuesDisabled()
        {
            numberZero.Enabled = false;
            numberOne.Enabled = false;
            numberTwo.Enabled = false;
            numberThree.Enabled = false;
            numberFour.Enabled = false;
            numberFive.Enabled = false;
            numberSix.Enabled = false;
            numberSeven.Enabled = false;
            numberEight.Enabled = false;
            numberNine.Enabled = false;
            coma.Enabled = false;
        }

       
        /**
         * Funkcia umožní stláčať tlačidlá operátorov
         */
        private void operationsEnabled()
        {
            add.Enabled = true;
            sub.Enabled = true;
            mul.Enabled = true;
            div.Enabled = true;
            powerOf.Enabled = true;
            sqrt.Enabled = true;
            factorial.Enabled = true;
            abs.Enabled = true;
        }

        /**
         * Funkcia znemožní stláčať tlačidlá operátov
         */
        private void operationsDisabled()
        {
            add.Enabled = false;
            sub.Enabled = false;
            mul.Enabled = false;
            div.Enabled = false;
            powerOf.Enabled = false;
            sqrt.Enabled = false;
            factorial.Enabled = false;
            abs.Enabled = false;
        }

        /**
         * Funkcia vynuluje textbox, premennú result a mathError a isDecimal nastaví na false,
         * nastaví stlačitelnosť všetkých tlačidiel
         * Spustí sa v prípade stlačenia tlačidla "AC"
         * 
         * @param sender referencia na objekt, ktorý vyvolal udalosť
         * @param e Poskytuje špecifiká objektu udalosti
         */
        private void clear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
            mathError = false;
            isDecimal = false;

            valuesEnabled();
            operationsEnabled();
            equal.Enabled = true;
        }





        /**
         * Funkcia vypíše nápovedu ku kalkulačke
         * Spustí sa v prípade stlačenia tlačidla "?"
         * @param sender referencia na objekt, ktorý vyvolal udalosť
         * @param e Poskytuje špecifiká objektu udalosti
         */
        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulačka IVS Copyright (C) 2020 Andrej Hýroš\n\n" +
                "Nápoveda:\n" +
                "Kalkulačka zvláda následujúce operácie: sčítanie(+), odčítanie(-), násobenie(×), delenie(÷), prirodzené exponenty((x)ʸ), obecnú odmocninu(√), faktoriál(!) a absolútnu hodnotu(|x|)\n\n" +
                "Postup: Užívateľ zadá číselny operand, následne zvolí operátor a v príprade binárnej operácie zadá druhý operand, pričom po stlačení klávesy \"=\" sa vypíše výsledok a je možné pokračovať " +
                "v zadaní daľšieho operátoru.\n" +
                "V prípade unárnej operácie sa vypíše výsledok ihneď po zadaní operátora a je možné zadať další operátor.\n" +
                "Po zadaní operátora musí následovať čiselný operand.\n\n" +
                "Pri odmocnine/mocnine sa odmocnitel/exponent píše ako druhý operand po zadaní operátora\n\n" +
                "V prípade výsledku \"Math Error\", \"Syntax Error\" alebo \"Error: Out of Range\" musí užívateľ stlačiť klávesu \"AC\" a môže pokračovať v počítaní");
        }








        /**
         * Funkcia spracúva stlačené tlačidlá hodnôt
         * Spustí sa v prípade stlačenia tlačidiel čísel alebo čiarky
         * 
         * @param sender referencia na objekt, ktorý vyvolal udalosť
         * @param e Poskytuje špecifiká objektu udalosti
         */
        private void numClick(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (opPerformed == true)) {
                textBox.Clear();
            }


            opPerformed = false;
            Button numButton = (Button)sender;

            if (textBox.Text == ".")
            {
                textBox.Text = "0.";
            }

            if (numButton.Text == ".") {
                isDecimal = true;
                if (!textBox.Text.Contains(".")) {
                    textBox.Text = textBox.Text + numButton.Text;
                }
            }
            else

            //pripisovanie cisel pre viacciferne honoty
            textBox.Text = textBox.Text + numButton.Text;
         

        }








        /**
         * Funkcia spracúva stlačenie operátorov
         * Spustí sa v prípade stlačenia tlačidla operátorov
         * 
         * @param sender referencia na objekt, ktorý vyvolal udalosť
         * @param e Poskytuje špecifiká objektu udalosti
         */
        private void opClick(object sender, EventArgs e)
        {
            equal.Enabled = true;
            operationsDisabled();
            valuesEnabled();

            Button opButton = (Button)sender;

            if ((result != 0) && (eqClicked == false)) {
                equal.PerformClick();

                equal.Enabled = true;

                valuesEnabled();

                op = opButton.Text;
                opPerformed = true;
                //equal.PerformClick();

            }
            else
            {
                op = opButton.Text;
                result = Double.Parse(textBox.Text);
                opPerformed = true;
                eqClicked = false;
            }

            //v pripade tychto troch operacii sa stlaci "=" automaticky
            if (opButton.Text == "!" || opButton.Text == "|x|")
            {
                equal.PerformClick();
            }
        }






        //vytovorenie instancie triedy s funkciami
        calculate kalk = new calculate();

        /**
         * Funkcia prevádza samotný výpočet
         * Spustí sa stlačením tlačidla "="
         * 
         * @param sender referencia na objekt, ktorý vyvolal udalosť
         * @param e Poskytuje špecifiká objektu udalosti
         */
        private void eqClick(object sender, EventArgs e)
        {
            //switch rozlisi ktora operacia ma nasledovat
            switch (op)
            {
                case "+":
                    textBox.Text = (kalk.plus(result, Double.Parse(textBox.Text))).ToString();
                    break;

                case "-":
                    textBox.Text = (kalk.sub(result, Double.Parse(textBox.Text))).ToString();
                    break;

                case "×":
                    textBox.Text = (kalk.mul(result, Double.Parse(textBox.Text))).ToString();
                    break;

                case "÷":
                    if (textBox.Text == "0")
                    {
                        mathErr();
                        break;
                    }
                    textBox.Text = (kalk.div(result, Double.Parse(textBox.Text))).ToString();
                    break;

                case "(x)ʸ":
                    int exponent;
                    parsed = Int32.TryParse(textBox.Text, out exponent);
                    if (parsed == true)
                    {
                        textBox.Text = (kalk.expo(result, exponent)).ToString();
                        if (textBox.Text == "∞")
                        {
                            textBox.Text = "Error: Out of Range...";
                            mathError = true;
                        }
                    }
                    else
                    {
                        syntErr();
                        break;
                    }
                    parsed = false;
                    break;
                    //koniec case: (x)ʸ



                case "√":
                    if (result == 0)
                    {
                        textBox.Text = "0";
                        break;
                    }
                    if (result < 0)
                    {
                        mathErr();
                        break;
                    }
                    int index;

                    //true == ak sa podarí premena typu double na typ int32
                    parsed = Int32.TryParse(textBox.Text, out index);
                    if (index == 0)
                    {
                        mathErr();
                        break;
                    }

                    //ak sa podarila premena a index != 0, dojde k výpočtu
                    if (parsed == true)
                    {
                        textBox.Text = (kalk.ntrt(result, index)).ToString("0.00000000");
                        if (textBox.Text == "∞")
                        {
                            textBox.Text = "Error: Out of Range...";
                            mathError = true;
                        }
                    }
                    else //ak sa nepodarila premena = bol zadany nevalidný operator = syntax error
                    {
                        syntErr();
                        break;
                    }
                    parsed = false;
                    break;
                    //koniec case: √


                case "!":
                    //0! sa vzdy = 1
                    if (result == 0)
                    {
                        textBox.Text = "1";
                        break;
                    }
                    //ak je operandom zaporne alebo desatinné číslo = math error
                    if (result < 0 || isDecimal == true)
                    {
                        mathErr();
                        break;
                    }
                    textBox.Text = (kalk.fact(result)).ToString();
                    break;


                case "|x|":
                    textBox.Text = (kalk.abs(result)).ToString();
                    break;

                default:
                    break;
            }
            //koniec switchu



            equal.Enabled = false;
            valuesDisabled();

            //ak plati matherror deaktivuju sa tlacitka, ak neplati, pokracuje sa dalej
            if (mathError == false)
            {
                operationsEnabled();
                eqClicked = true;
                result = Double.Parse(textBox.Text);
            }
            else
            {
                valuesDisabled();
                operationsDisabled();  
                equal.Enabled = false;
                
            }
        }
    }
}

/*** Koniec súboru Form1.cs ***/