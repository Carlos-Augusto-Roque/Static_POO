using System;

namespace Static_POO.classes
{
    public class ConversorMoedas
    {
        private static float cotacaoDolar = 5.10f;
        private static float cotacaoEuro = 6.22f;
        private static float cotacaoLibras = 6.82f;
        
        
        public static float RealDolar(float valorRS){
            return valorRS/cotacaoDolar;
        }
        public static float DolarReal(float valorUS){
            return cotacaoDolar * valorUS;
        }
        public static float RealEuro(float valorRS){
            return valorRS/cotacaoEuro;
        }
        public static float EuroReal(float valorEU){
            return cotacaoEuro * valorEU;
        }
        public static float RealLibras(float valorRS){
            return valorRS / cotacaoLibras;
        }
        public static float LibrasReal(float valorLI){
            return cotacaoLibras * valorLI;
        }
        
    }
}