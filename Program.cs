
using FileManipulation;
using FileManipulation.Utils;
using System;
using System.Text;
using System.Text.Unicode;
using static System.Net.Mime.MediaTypeNames;

partial class Program
{
   
    static void Main(string[] arg)
    
    
    
    
    {

        HandlingFileRead2 HandlingFileRead2 = new HandlingFileRead2();

        //HandlingFileRead2.ReadFile("contas.txt");


        //HandlingFileRead2.CreateFile("contasExportadas.txt");

        //HandlingFileRead2.CreateFileWithWriter("contaNova.txt");

        //HandlingFileRead2.ReadFile("contaNova.txt");

        //HandlingFileRead2.CreateFileTeste("Teste.txt");

        //HandlingFileRead2.CreateTesteText("TesteTextoNormal.txt");

        HandlingBinaryFiles HandlingBinaryFiles = new HandlingBinaryFiles();


       
        HandlingBinaryFiles.CreateFileBina("TesteBinario.txt");

        HandlingBinaryFiles.ReadBina("TesteBinario.txt");



    }




}