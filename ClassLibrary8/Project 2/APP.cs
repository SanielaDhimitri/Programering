using System;
using System.Collections.Generic;
using ClassLibrary8;
using ClassLibrary8.Repo;

namespace Project_2
{
    public class APP
    {

        private BådRepo bådRepo = new BådRepo();
        public void Run()
        
                {
                    Console.WriteLine("VIS ALLE BÅDE");

                    List<Båd> både = bådRepo.GetAllBåder(); // kald metoden GetAll fra bådRepo


                    if (både.Count == 0)
                    {
                        Console.WriteLine("Der er ingen båd foundt.");
                    }

                    else
                    {
                        for (int i = 0; i < både.Count; i++)
                        {
                            Console.WriteLine(både[i]);
                        }
                    }

                   
                }
            
    }
}

