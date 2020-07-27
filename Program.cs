using System;

namespace Operators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Incremento();
            //Decremento();
            //Multiplicador();
            //Divisor();
            //Resto();
            //Adicao();
            //Subtracao();
            //AdicaoComposta();
            //SubtracaoComposta();
            //MultiplicacaoComposta();
            //DivisaoComposta();
            //RestoComposto();

            //LogicoNegativo();
            //LogicoE();
            //LogicoOu();
            LogicoCondicionalE();
            //LogicoCondicionalOu();
            //LogicoCompostoE();
            //LogicoCompostoOu();

            return;
        }

        #region .: Aritméticos :.

        private static void Incremento()
        {
            int numero = 10;

            numero++;

            Console.WriteLine($"resultado = {numero}");
        }

        private static void Decremento()
        {
            int numero = 10;

            numero--;

            Console.WriteLine($"resultado = {numero}");
        }

        private static void Multiplicador()
        {
            int primeiro = 10;
            int segundo = 2;

            int terceiro = primeiro * segundo;

            Console.WriteLine($"resultado = {terceiro}");
        }

        private static void Divisor()
        {
            int primeiro = 10;
            int segundo = 2;

            int terceiro = primeiro / segundo;

            Console.WriteLine($"resultado = {terceiro}");
        }

        private static void Resto()
        {
            int primeiro = 11;
            int segundo = 2;

            int terceiro = primeiro % segundo;

            Console.WriteLine($"resultado = {terceiro}");
        }

        private static void Adicao()
        {
            int primeiro = 10;
            int segundo = 2;

            int terceiro = primeiro + segundo;

            Console.WriteLine($"resultado = {terceiro}");
        }

        private static void Subtracao()
        {
            int primeiro = 10;
            int segundo = 2;

            int terceiro = primeiro - segundo;

            Console.WriteLine($"resultado = {terceiro}");
        }

        private static void AdicaoComposta()
        {
            int primeiro = 10;

            primeiro += 2;

            Console.WriteLine($"resultado = {primeiro}");
        }

        private static void SubtracaoComposta()
        {
            int primeiro = 10;

            primeiro -= 2;

            Console.WriteLine($"resultado = {primeiro}");
        }

        private static void MultiplicacaoComposta()
        {
            int primeiro = 10;

            primeiro *= 2;

            Console.WriteLine($"resultado = {primeiro}");
        }

        private static void DivisaoComposta()
        {
            int primeiro = 10;

            primeiro /= 2;

            Console.WriteLine($"resultado = {primeiro}");
        }

        private static void RestoComposto()
        {
            int primeiro = 11;

            primeiro %= 2;

            Console.WriteLine($"resultado = {primeiro}");
        }

        #endregion .: Aritméticos :.

        #region .: Lógicos :.

        private static void LogicoNegativo()
        {
            bool sucesso = false;

            Console.WriteLine($"resultado = {!sucesso}");
        }

        private static void LogicoE()
        {
            bool sucesso = true & SegundaOperacao();

            Console.WriteLine($"resultado = {sucesso}");
        }

        private static void LogicoOu()
        {
            bool sucesso = false | SegundaOperacao();

            Console.WriteLine($"resultado = {sucesso}");
        }

        private static void LogicoCondicionalE()
        {
            bool sucesso = false && SegundaOperacao();

            Console.WriteLine($"resultado = {sucesso}");
        }

        private static bool SegundaOperacao()
        {
            Console.WriteLine("Segunda Operação!");

            return true;
        }

        private static void LogicoCondicionalOu()
        {
            bool sucesso = false || SegundaOperacao();

            Console.WriteLine($"resultado 1 = {sucesso}");

            sucesso = true || SegundaOperacao();

            Console.WriteLine($"resultado 2 = {sucesso}");
        }

        private static void LogicoCompostoE()
        {
            bool sucesso = false;

            sucesso &= true;

            Console.WriteLine($"resultado = {sucesso}");
        }

        private static void LogicoCompostoOu()
        {
            bool sucesso = false;

            sucesso |= true;

            Console.WriteLine($"resultado = {sucesso}");
        }

        #endregion .: Lógicos :.

        #region .: Equalidade :.

        private static void Equalidade()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro == segundo}");
        }

        private static void Inequalidade()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro != segundo}");
        }

        #endregion .: Equalidade :.

        #region .: Comparativo :.

        private static void Menor()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro < segundo}");
        }

        private static void Maior()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro > segundo}");
        }

        private static void MenorIgual()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro <= segundo}");
        }

        private static void MaiorIgual()
        {
            int primeiro = 10;
            int segundo = 15;

            Console.WriteLine($"resultado = {primeiro >= segundo}");
        }

        #endregion .: Comparativo :.

        #region .: Conversao :.

        private static void ConversaoExplicito()
        {
            int numero = 10;

            decimal numeroDecimal = (decimal)numero;

            Console.WriteLine($"resultado = {numeroDecimal}");
        }

        private static void ConversaoImplicito()
        {
            int numero = 10;

            decimal numeroDecimal = numero;

            Console.WriteLine($"resultado = {numeroDecimal}");
        }

        #endregion .: Conversao :.
    }
}