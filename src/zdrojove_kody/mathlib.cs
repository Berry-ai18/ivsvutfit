/**
* @file mathlib.cs
* @brief simulácia knižnice obsahujúca matematické funkcie využité v kalkulačke
* @author Patrik Smola 
* @author Peter Čellár
*/
using System;

namespace Library
{
    public class TheClassToTest{

        static void Main(string[] args){


        /**
        * Sčítanie
        * @param x Prvý operand
        * @param y Druhý operand
        */
        public double plus(double x, double y){

            return x + y;

        }

        /**
        * Odčítanie
        * @param x Prvý operand
        * @param y Druhý operand
        */
        public double minus(double x, double y){

            return x - y;

        }

        /**
        * Násobenie
        * @param x Prvý operand
        * @param y Druhý operand
        */
        public double mul(double x, double y){
        
            return x * y;

        }


        /**
        * Delenie
        * @param x Prvý operand
        * @param y Druhý operand
        */
        public double div(double x, double y){
        
            return  x / y;

        }


        /**
        * Umocňovanie
        * @param x Prvý operand
        * @param y Druhý operand - exponent
        */
        public double exp(double x, double y){

            double result = 1;
            for (double i = 0; i < y; i++){
                result = result * x;
            }
            return result;
        }


        /**
        * Faktorial
        * @param x operand
        */
        public double fact(double x){

            double result = 1;
            for (double i = x; i > 1; i--)
            {
            result = result * i;
            }
        	return result;
        }


        /**
        * Sčítanie
        * @param x Prvý operand
        * @param y Druhý operand - odmocnitel
        */
        public double sqrt(double x, double y){
            // x je zaklad
            // y je index

        double xPre = 1;

        double eps = 0.0001;

        double delX = 2147483647; 
        double xK = 0.0; 

        while (delX > eps) 
        { 
            // calculating current value from previous 
            // value by newton's method 
            xK = ((y- 1.0) * xPre + 
            (double)x / exp(xPre, y - 1)) / (double)y; 
            delX = abs(xK - xPre); 
            xPre = xK; 
        } 
      
        return xK; 



        /*double result = 1;
        double temp;
        result = x / 2;

            do{
                temp = result;
                result = (temp + (x / temp)) / 2;
            }
            while ((temp - result) != 0);
            return result;*/
        }

        /**
        * Sčítanie
        * @param x operand
        * 
        */
        public double abs(double x){
            
            if (x < 0)
            {
                return -x;
            }
            return x;
        }
    }
}
}

