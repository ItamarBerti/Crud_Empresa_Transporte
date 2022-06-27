﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Menu
    {
        Empresa empresa = new Empresa();
        public void MostrarMenuInicial()
        {
            Console.WriteLine("1- Motorista.");
            Console.WriteLine("2- Caminhão.");
            Console.WriteLine("3- Viagem.");
            string opcao = Console.ReadLine();
            MostrarMenuCrud(opcao);       
        }
        public void MostrarMenuCrud(string opcao)
        {
            Console.WriteLine("1- Cadastrar.");
            Console.WriteLine("2- Atualizar.");
            Console.WriteLine("3- Remover.");
            string opcao1 = Console.ReadLine();

            switch ((opcao, opcao1))
            {
                case ("1", "1"):
                    empresa.CadastroMotorista();
                    break;
                case ("1", "2"):
                    empresa.AtualizarMotorista();
                    break;
                case ("1", "3"):
                    empresa.RemoveMotorista();
                    break;
                case ("2", "1"):
                    empresa.CadastroCaminhao();
                    break;
                case ("2", "2"):
                    empresa.AtualizarCaminhao();
                    break;
                case ("2", "3"):              
                    empresa.RemoverCaminhao();
                    break;
                case ("3", "1"):
                    empresa.CadastroViagens();
                    break;
                case("3", "2"):
                    empresa.AtualizarViagem();
                    break;
                case ("3", "3"):
                    empresa.RemoveViagem();
                    break;                              
            }
        }
    

    }
}
