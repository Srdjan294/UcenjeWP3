using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            
                
                    Console.WriteLine("Ciklična matrica");

                    Console.WriteLine("Unesi broj redova: ");
                    int m = int.Parse(Console.ReadLine());

                
                    Console.WriteLine("Unesite broj stupaca: ");
                    int n = int.Parse(Console.ReadLine());

                    
                        int[,] matrica = new int[m, n];

                        int i = 1;
                        int minRed = 0;
                        int minStu = 0;
                        int maxRed = m - 1;
                        int maxStu = n - 1;

            while(i < m*n){

                for (int j = maxStu; j >= minStu; j--)
                {
                    matrica[maxRed, j] = i++;
                }

                for (int j = maxRed - 1; j >= minRed; j--)
                {
                    matrica[j, minStu] = i++;
                }
                for (int j = minStu + 1; j <= maxStu; j++)
                {
                    matrica[minRed, j] = i++;
                }
                for (int j = minRed + 1; j <= maxRed - 1; j++)
                {
                    matrica[j, maxStu] = i++;
                }

                minStu++;
                minRed++;
                maxStu--;
                maxRed--;

            }
                            for (i = 0; i < m; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    Console.Write(matrica[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                
             
        
    }

