namespace real_em_euro.classes
{
    public class Conversor
    {
        public static  float CotacaoDolar = 5.24f;
            
            public static float RealParaDolar(float valorRS){
                return valorRS / CotacaoDolar;
            }

            public static float DolarParaReais(float valorUS){
                return CotacaoDolar * valorUS;
            }
        
    }
}