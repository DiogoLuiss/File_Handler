using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FileManipulation.Utils
{
    public class HandlingFileRead2
    {

        public void ReadFile(string AddressFile)
        {
  

            using (var FlowFile = new FileStream(AddressFile, FileMode.Open)) //Acha e por assim dizer abre os arquivos 
            {
                var Reader = new StreamReader(FlowFile);

                while (!Reader.EndOfStream)
                {

                    var FirstLine = Reader.ReadLine();

                    var Fields = FirstLine.Split(",");

                    int NumberAgency = int.Parse(Fields[0]);

                    int NumberAccount = int.Parse(Fields[1]);

                    double Balance = double.Parse(Fields[2].Replace(".", ","));

                    string ClientName = Fields[3];

                    var CurrentAccount = new CurrentAccount(NumberAgency, NumberAccount)
                    {
                        Balance = Balance,
                        NameClient = ClientName
                    };

                    CurrentAccount.ListAccount.Add(CurrentAccount);

                    Console.WriteLine($"Nome do cliente: {ClientName}, Numero da conta: {NumberAccount}, Numero da agencia: {NumberAgency}, com um saldo de: R${Balance} ");

                }
            }



        }

        public void CreateFile(string AddressFile) 
        {

            using ( var FlowFile = new FileStream(AddressFile,FileMode.Create))
            {
                var AccountString = "456,7895,4785.40,Diogo Luis";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(AccountString);

                for (int i = 0; i < 1000; i++)
                {
                    FlowFile.Write(bytes, 0, bytes.Length);
                    
                }

     


            }


        }

        public void CreateFileWithWriter(string AddressFile)
        {

            using (var FlowFile = new FileStream(AddressFile, FileMode.Create))
            using (var writer = new StreamWriter(FlowFile))
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.Write("456,7895,4785.40,Diogo Luis da Silva");
                }

               
            }

        }
        public void CreateFileTeste(string AddressFile)
        {

            using (var FlowFile = new FileStream(AddressFile, FileMode.Create))
            using (var writer = new StreamWriter(FlowFile))
            {
                //Quando se usa os metodos de escrita em arquivo a demora é maior, porque só é escrito ao terminar todo processo.
                for (int i = 0; i < 1000; i++)
                {
                    writer.WriteLine($"Linha {i}");
                    writer.Flush(); //Usar o Flush, modifica o arquivo a cada passada no código.
                    Console.WriteLine($"Aperte alguma tecla {i}");
                    Console.ReadKey();


                }
                //Apenas quando parar de rodar vai funcionar

             
            }

        }
         
   

        public void CreateTesteText(string AddressFile)
        {

            using (var FlowFile = new FileStream(AddressFile, FileMode.Create))
            using (var writer = new StreamWriter(FlowFile))
            {
                for (int i = 0; i < 50000; i++)
                {

                    writer.Write("dasundasundasndasndnas");



                }


            }

        }


    }
}