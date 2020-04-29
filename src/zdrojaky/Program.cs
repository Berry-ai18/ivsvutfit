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
 * Súbor: Program.cs
 * Dátum: 18.04.2020
 * Posledná zmena: 18.04.2020
 * Autor: Andrej Hýroš - xhyros00
 * Popis: Súbor obsahujúci main funkciu aplikácie
 * ********************************************************************************************/
/**
 * @file Program.cs
 * @brief Súbor obsahujúci main funkciu aplikácie
 * @author Andrej Hýroš
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVS_Calc_v01
{
    /**
     * @class Trieda obsahujúca main funkciu aplikácie
     */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        /**
         * Main funkcia aplikácie
         */
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
