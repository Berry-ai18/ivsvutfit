using System;

namespace Kniznica
{
    public class kniznica{

        public double plus(double x, double y){

            return x + y;

        }

        public double minus(double x, double y){

            return x - y;

        }

        public double mul(double x, double y){
        
            return x * y;

        }

        public double div(double x, double y){
        
            return  x / y;

        }

        public double exp(double x, double y){

            double result = 1;
            for (double i = 0; i < y; i++){
                result = result * x;
            }
            return result;
        }

        public double fact(double x){

            double result = 1;
            for (double i = x; i > 1; i--)
            {
            result = result * i;
            }
        	return result;
        }

        public double sqrt(double x){

        double result = 1;
        double temp;
        result = x / 2;

            do{
                temp = result;
                result = (temp + (x / temp)) / 2;
            }
            while ((temp - result) != 0);
            return result;
        }
        public double abs(double x){
            
            if (x < 0)
            {
                return -x;
            }
            return x;
        }
    }
}