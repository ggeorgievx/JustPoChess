﻿using System;
using System.Text;
using System.Threading;

namespace JustPoChess.Client.View.Menu
{
    public class MenuUnix
    {
        public static void InitialScreen()
        {
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"                                                        
                                           o   |\ ,'`. /||\ ,OO. /|    o     
                   _   _   _   |\__      /\^/\ | `'`'`' || `'`'`' |  /\^/\   |\__     _   _   _ 
                  | |_| |_| | /   o\__  |  /  ) \      /  \      /  |  /  ) /   o\__ | |_| |_| |
                   \       / |    ___=' | /  /   |    |    |    |   | /  / |    ___=' \       / 
                    |     |  |    \      Y  /    |    |    |    |    Y  /  |    \      |     |
                    |     |   \    \     |  |    |    |    |    |    |  |   \    \     |     |  
                    |     |    >    \    |  |    |    |    |    |    |  |    >    \    |     |  
                   /       \  /      \  /    \  /      \  /      \  /    \  /      \  /       \ 
                  |_________||________||______||________||________||______||________||_________|
                     __         __       __       __        __       __       __         __   
                    (  )       (  )     (  )     (  )      (  )     (  )     (  )       (  )  
                     ><         ><       ><       ><        ><       ><       ><         ><   
                    |  |       |  |     |  |     |  |      |  |     |  |     |  |       |  |  
                   /    \     /    \   /    \   /    \    /    \   /    \   /    \     /    \ 
                  |______|   |______| |______| |______|  |______| |______| |______|   |______|");
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"            
     /$$$$$                       /$$           /$$$$$$$            /$$$$$$  /$$                                   
    |__  $$                      | $$          | $$__  $$          /$$__  $$| $$                                   
       | $$ /$$   /$$  /$$$$$$$ /$$$$$$        | $$  \ $$ /$$$$$$ | $$  \__/| $$$$$$$   /$$$$$$   /$$$$$$$ /$$$$$$$
       | $$| $$  | $$ /$$_____/|_  $$_/        | $$$$$$$//$$__  $$| $$      | $$__  $$ /$$__  $$ /$$_____//$$_____/
  /$$  | $$| $$  | $$|  $$$$$$   | $$          | $$____/| $$  \ $$| $$      | $$  \ $$| $$$$$$$$|  $$$$$$|  $$$$$$ 
 | $$  | $$| $$  | $$ \____  $$  | $$ /$$      | $$     | $$  | $$| $$    $$| $$  | $$| $$_____/ \____  $$\____  $$
 |  $$$$$$/|  $$$$$$/ /$$$$$$$/  |  $$$$/      | $$     |  $$$$$$/|  $$$$$$/| $$  | $$|  $$$$$$$ /$$$$$$$//$$$$$$$/
  \______/  \______/ |_______/    \___/        |__/      \______/  \______/ |__/  |__/ \_______/|_______/|_______/");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{new string(' ', 40)}PRESS ANY KEY TO CONTINUE...");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{new string(' ', 43)}(\u00a9) 2017 CodeBenders");

            while(!Console.KeyAvailable) { }

            Console.Clear();
            Console.ResetColor();
        }

        public static void InitializeMenu()
        {
            var menuOptions = 1;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var userInput = Console.ReadKey();

                    switch (userInput.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (menuOptions == 1)
                            {
                                menuOptions = 5;
                            }
                            else
                            {
                                menuOptions--;
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (menuOptions == 5)
                            {
                                menuOptions = 1;
                            }
                            else
                            {
                                menuOptions++;
                            }
                            break;

                        case ConsoleKey.Enter:
                            //do stuff
                            break;
                    }

                    Console.Clear();
                    switch (menuOptions)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"$$\   $$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$$$$$$$\  $$$$$$\ $$$$$$$$\                                    
$$ |  $$ |$$  __$$\\__$$  __|      $$  __$$\ $$  _____|$$  __$$\\__$$  __|                                   
$$ |  $$ |$$ /  $$ |  $$ |         $$ /  \__|$$ |      $$ /  $$ |  $$ |                                      
$$$$$$$$ |$$ |  $$ |  $$ |         \$$$$$$\  $$$$$\    $$$$$$$$ |  $$ |                                      
$$  __$$ |$$ |  $$ |  $$ |          \____$$\ $$  __|   $$  __$$ |  $$ |                                      
$$ |  $$ |$$ |  $$ |  $$ |         $$\   $$ |$$ |      $$ |  $$ |  $$ |                                      
$$ |  $$ | $$$$$$  |  $$ |         \$$$$$$  |$$$$$$$$\ $$ |  $$ |  $$ |                                      
\__|  \__| \______/   \__|          \______/ \________|\__|  \__|  \__|    ");
                            Console.ResetColor();
                            Console.WriteLine(@"                                                                                                             
                                                                                                             
                                                                                                             
 $$$$$$\  $$\   $$\ $$\       $$$$$$\ $$\   $$\ $$$$$$$$\                                                    
$$  __$$\ $$$\  $$ |$$ |      \_$$  _|$$$\  $$ |$$  _____|                                                   
$$ /  $$ |$$$$\ $$ |$$ |        $$ |  $$$$\ $$ |$$ |                                                         
$$ |  $$ |$$ $$\$$ |$$ |        $$ |  $$ $$\$$ |$$$$$\                                                       
$$ |  $$ |$$ \$$$$ |$$ |        $$ |  $$ \$$$$ |$$  __|                                                      
$$ |  $$ |$$ |\$$$ |$$ |        $$ |  $$ |\$$$ |$$ |                                                         
 $$$$$$  |$$ | \$$ |$$$$$$$$\ $$$$$$\ $$ | \$$ |$$$$$$$$\                                                    
 \______/ \__|  \__|\________|\______|\__|  \__|\________|                                                   
                                                                                                             
                                                                 ");
                            Console.WriteLine(@"$$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\                         
$$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|                        
$$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |                          
\$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |                          
 \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |                          
  \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |                          
   \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\                         
    \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|                        
                                                                                                             
                                                                                             ");
                            Console.WriteLine(@" $$$$$$\  $$$$$$\       $$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\ 
$$  __$$\ \_$$  _|      $$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|
$$ /  $$ |  $$ |        $$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |  
$$$$$$$$ |  $$ |        \$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |  
$$  __$$ |  $$ |         \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |  
$$ |  $$ |  $$ |          \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |  
$$ |  $$ |$$$$$$\          \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\ 
\__|  \__|\______|          \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|
                                                                                                             
                                                                                                             
                           ");

                            Console.WriteLine(@"$$$$$$$$\ $$\   $$\ $$$$$$\ $$$$$$$$\                                                                        
$$  _____|$$ |  $$ |\_$$  _|\__$$  __|                                                                       
$$ |      \$$\ $$  |  $$ |     $$ |                                                                          
$$$$$\     \$$$$  /   $$ |     $$ |                                                                          
$$  __|    $$  $$<    $$ |     $$ |                                                                          
$$ |      $$  /\$$\   $$ |     $$ |                                                                          
$$$$$$$$\ $$ /  $$ |$$$$$$\    $$ |                                                                          
\________|\__|  \__|\______|   \__|  ");
                            break;

                        case 2:
                            Console.WriteLine(@"$$\   $$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$$$$$$$\  $$$$$$\ $$$$$$$$\                                    
$$ |  $$ |$$  __$$\\__$$  __|      $$  __$$\ $$  _____|$$  __$$\\__$$  __|                                   
$$ |  $$ |$$ /  $$ |  $$ |         $$ /  \__|$$ |      $$ /  $$ |  $$ |                                      
$$$$$$$$ |$$ |  $$ |  $$ |         \$$$$$$\  $$$$$\    $$$$$$$$ |  $$ |                                      
$$  __$$ |$$ |  $$ |  $$ |          \____$$\ $$  __|   $$  __$$ |  $$ |                                      
$$ |  $$ |$$ |  $$ |  $$ |         $$\   $$ |$$ |      $$ |  $$ |  $$ |                                      
$$ |  $$ | $$$$$$  |  $$ |         \$$$$$$  |$$$$$$$$\ $$ |  $$ |  $$ |                                      
\__|  \__| \______/   \__|          \______/ \________|\__|  \__|  \__|    ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"                                                                                                             
                                                                                                             
                                                                                                             
 $$$$$$\  $$\   $$\ $$\       $$$$$$\ $$\   $$\ $$$$$$$$\                                                    
$$  __$$\ $$$\  $$ |$$ |      \_$$  _|$$$\  $$ |$$  _____|                                                   
$$ /  $$ |$$$$\ $$ |$$ |        $$ |  $$$$\ $$ |$$ |                                                         
$$ |  $$ |$$ $$\$$ |$$ |        $$ |  $$ $$\$$ |$$$$$\                                                       
$$ |  $$ |$$ \$$$$ |$$ |        $$ |  $$ \$$$$ |$$  __|                                                      
$$ |  $$ |$$ |\$$$ |$$ |        $$ |  $$ |\$$$ |$$ |                                                         
 $$$$$$  |$$ | \$$ |$$$$$$$$\ $$$$$$\ $$ | \$$ |$$$$$$$$\                                                    
 \______/ \__|  \__|\________|\______|\__|  \__|\________|                                                   
                                                                                                             
                                                                 ");
                            Console.ResetColor();
                            Console.WriteLine(@"$$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\                         
$$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|                        
$$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |                          
\$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |                          
 \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |                          
  \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |                          
   \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\                         
    \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|                        
                                                                                                             
                                                                                             ");
                            Console.WriteLine(@" $$$$$$\  $$$$$$\       $$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\ 
$$  __$$\ \_$$  _|      $$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|
$$ /  $$ |  $$ |        $$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |  
$$$$$$$$ |  $$ |        \$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |  
$$  __$$ |  $$ |         \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |  
$$ |  $$ |  $$ |          \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |  
$$ |  $$ |$$$$$$\          \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\ 
\__|  \__|\______|          \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|
                                                                                                             
                                                                                                             
                           ");

                            Console.WriteLine(@"$$$$$$$$\ $$\   $$\ $$$$$$\ $$$$$$$$\                                                                        
$$  _____|$$ |  $$ |\_$$  _|\__$$  __|                                                                       
$$ |      \$$\ $$  |  $$ |     $$ |                                                                          
$$$$$\     \$$$$  /   $$ |     $$ |                                                                          
$$  __|    $$  $$<    $$ |     $$ |                                                                          
$$ |      $$  /\$$\   $$ |     $$ |                                                                          
$$$$$$$$\ $$ /  $$ |$$$$$$\    $$ |                                                                          
\________|\__|  \__|\______|   \__|  ");
                            break;

                        case 3:
                            Console.WriteLine(@"$$\   $$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$$$$$$$\  $$$$$$\ $$$$$$$$\                                    
$$ |  $$ |$$  __$$\\__$$  __|      $$  __$$\ $$  _____|$$  __$$\\__$$  __|                                   
$$ |  $$ |$$ /  $$ |  $$ |         $$ /  \__|$$ |      $$ /  $$ |  $$ |                                      
$$$$$$$$ |$$ |  $$ |  $$ |         \$$$$$$\  $$$$$\    $$$$$$$$ |  $$ |                                      
$$  __$$ |$$ |  $$ |  $$ |          \____$$\ $$  __|   $$  __$$ |  $$ |                                      
$$ |  $$ |$$ |  $$ |  $$ |         $$\   $$ |$$ |      $$ |  $$ |  $$ |                                      
$$ |  $$ | $$$$$$  |  $$ |         \$$$$$$  |$$$$$$$$\ $$ |  $$ |  $$ |                                      
\__|  \__| \______/   \__|          \______/ \________|\__|  \__|  \__|    ");
                            Console.WriteLine(@"                                                                                                             
                                                                                                             
                                                                                                             
 $$$$$$\  $$\   $$\ $$\       $$$$$$\ $$\   $$\ $$$$$$$$\                                                    
$$  __$$\ $$$\  $$ |$$ |      \_$$  _|$$$\  $$ |$$  _____|                                                   
$$ /  $$ |$$$$\ $$ |$$ |        $$ |  $$$$\ $$ |$$ |                                                         
$$ |  $$ |$$ $$\$$ |$$ |        $$ |  $$ $$\$$ |$$$$$\                                                       
$$ |  $$ |$$ \$$$$ |$$ |        $$ |  $$ \$$$$ |$$  __|                                                      
$$ |  $$ |$$ |\$$$ |$$ |        $$ |  $$ |\$$$ |$$ |                                                         
 $$$$$$  |$$ | \$$ |$$$$$$$$\ $$$$$$\ $$ | \$$ |$$$$$$$$\                                                    
 \______/ \__|  \__|\________|\______|\__|  \__|\________|                                                   
                                                                                                             
                                                                 ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"$$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\                         
$$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|                        
$$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |                          
\$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |                          
 \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |                          
  \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |                          
   \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\                         
    \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|                        
                                                                                                             
                                                                                             ");
                            Console.ResetColor();
                            Console.WriteLine(@" $$$$$$\  $$$$$$\       $$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\ 
$$  __$$\ \_$$  _|      $$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|
$$ /  $$ |  $$ |        $$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |  
$$$$$$$$ |  $$ |        \$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |  
$$  __$$ |  $$ |         \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |  
$$ |  $$ |  $$ |          \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |  
$$ |  $$ |$$$$$$\          \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\ 
\__|  \__|\______|          \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|
                                                                                                             
                                                                                                             
                           ");

                            Console.WriteLine(@"$$$$$$$$\ $$\   $$\ $$$$$$\ $$$$$$$$\                                                                        
$$  _____|$$ |  $$ |\_$$  _|\__$$  __|                                                                       
$$ |      \$$\ $$  |  $$ |     $$ |                                                                          
$$$$$\     \$$$$  /   $$ |     $$ |                                                                          
$$  __|    $$  $$<    $$ |     $$ |                                                                          
$$ |      $$  /\$$\   $$ |     $$ |                                                                          
$$$$$$$$\ $$ /  $$ |$$$$$$\    $$ |                                                                          
\________|\__|  \__|\______|   \__|  ");
                            break;

                        case 4:

                            Console.WriteLine(@"$$\   $$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$$$$$$$\  $$$$$$\ $$$$$$$$\                                    
$$ |  $$ |$$  __$$\\__$$  __|      $$  __$$\ $$  _____|$$  __$$\\__$$  __|                                   
$$ |  $$ |$$ /  $$ |  $$ |         $$ /  \__|$$ |      $$ /  $$ |  $$ |                                      
$$$$$$$$ |$$ |  $$ |  $$ |         \$$$$$$\  $$$$$\    $$$$$$$$ |  $$ |                                      
$$  __$$ |$$ |  $$ |  $$ |          \____$$\ $$  __|   $$  __$$ |  $$ |                                      
$$ |  $$ |$$ |  $$ |  $$ |         $$\   $$ |$$ |      $$ |  $$ |  $$ |                                      
$$ |  $$ | $$$$$$  |  $$ |         \$$$$$$  |$$$$$$$$\ $$ |  $$ |  $$ |                                      
\__|  \__| \______/   \__|          \______/ \________|\__|  \__|  \__|    ");
                            Console.WriteLine(@"                                                                                                             
                                                                                                             
                                                                                                             
 $$$$$$\  $$\   $$\ $$\       $$$$$$\ $$\   $$\ $$$$$$$$\                                                    
$$  __$$\ $$$\  $$ |$$ |      \_$$  _|$$$\  $$ |$$  _____|                                                   
$$ /  $$ |$$$$\ $$ |$$ |        $$ |  $$$$\ $$ |$$ |                                                         
$$ |  $$ |$$ $$\$$ |$$ |        $$ |  $$ $$\$$ |$$$$$\                                                       
$$ |  $$ |$$ \$$$$ |$$ |        $$ |  $$ \$$$$ |$$  __|                                                      
$$ |  $$ |$$ |\$$$ |$$ |        $$ |  $$ |\$$$ |$$ |                                                         
 $$$$$$  |$$ | \$$ |$$$$$$$$\ $$$$$$\ $$ | \$$ |$$$$$$$$\                                                    
 \______/ \__|  \__|\________|\______|\__|  \__|\________|                                                   
                                                                                                             
                                                                 ");
                            Console.WriteLine(@"$$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\                         
$$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|                        
$$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |                          
\$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |                          
 \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |                          
  \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |                          
   \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\                         
    \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|                        
                                                                                                             
                                                                                             ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@" $$$$$$\  $$$$$$\       $$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\ 
$$  __$$\ \_$$  _|      $$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|
$$ /  $$ |  $$ |        $$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |  
$$$$$$$$ |  $$ |        \$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |  
$$  __$$ |  $$ |         \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |  
$$ |  $$ |  $$ |          \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |  
$$ |  $$ |$$$$$$\          \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\ 
\__|  \__|\______|          \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|
                                                                                                             
                                                                                                             
                           ");
                            Console.ResetColor();
                            Console.WriteLine(@"$$$$$$$$\ $$\   $$\ $$$$$$\ $$$$$$$$\                                                                        
$$  _____|$$ |  $$ |\_$$  _|\__$$  __|                                                                       
$$ |      \$$\ $$  |  $$ |     $$ |                                                                          
$$$$$\     \$$$$  /   $$ |     $$ |                                                                          
$$  __|    $$  $$<    $$ |     $$ |                                                                          
$$ |      $$  /\$$\   $$ |     $$ |                                                                          
$$$$$$$$\ $$ /  $$ |$$$$$$\    $$ |                                                                          
\________|\__|  \__|\______|   \__|  ");
                            break;

                        case 5:
                            Console.WriteLine(@"$$\   $$\  $$$$$$\ $$$$$$$$\        $$$$$$\  $$$$$$$$\  $$$$$$\ $$$$$$$$\                                    
$$ |  $$ |$$  __$$\\__$$  __|      $$  __$$\ $$  _____|$$  __$$\\__$$  __|                                   
$$ |  $$ |$$ /  $$ |  $$ |         $$ /  \__|$$ |      $$ /  $$ |  $$ |                                      
$$$$$$$$ |$$ |  $$ |  $$ |         \$$$$$$\  $$$$$\    $$$$$$$$ |  $$ |                                      
$$  __$$ |$$ |  $$ |  $$ |          \____$$\ $$  __|   $$  __$$ |  $$ |                                      
$$ |  $$ |$$ |  $$ |  $$ |         $$\   $$ |$$ |      $$ |  $$ |  $$ |                                      
$$ |  $$ | $$$$$$  |  $$ |         \$$$$$$  |$$$$$$$$\ $$ |  $$ |  $$ |                                      
\__|  \__| \______/   \__|          \______/ \________|\__|  \__|  \__|    ");
                            Console.WriteLine(@"                                                                                                             
                                                                                                             
                                                                                                             
 $$$$$$\  $$\   $$\ $$\       $$$$$$\ $$\   $$\ $$$$$$$$\                                                    
$$  __$$\ $$$\  $$ |$$ |      \_$$  _|$$$\  $$ |$$  _____|                                                   
$$ /  $$ |$$$$\ $$ |$$ |        $$ |  $$$$\ $$ |$$ |                                                         
$$ |  $$ |$$ $$\$$ |$$ |        $$ |  $$ $$\$$ |$$$$$\                                                       
$$ |  $$ |$$ \$$$$ |$$ |        $$ |  $$ \$$$$ |$$  __|                                                      
$$ |  $$ |$$ |\$$$ |$$ |        $$ |  $$ |\$$$ |$$ |                                                         
 $$$$$$  |$$ | \$$ |$$$$$$$$\ $$$$$$\ $$ | \$$ |$$$$$$$$\                                                    
 \______/ \__|  \__|\________|\______|\__|  \__|\________|                                                   
                                                                                                             
                                                                 ");
                            Console.WriteLine(@"$$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\                         
$$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|                        
$$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |                          
\$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |                          
 \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |                          
  \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |                          
   \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\                         
    \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|                        
                                                                                                             
                                                                                             ");
                            Console.WriteLine(@" $$$$$$\  $$$$$$\       $$\    $$\ $$$$$$$$\ $$$$$$$\   $$$$$$\  $$\   $$\  $$$$$$\         $$$$$$\  $$$$$$\ 
$$  __$$\ \_$$  _|      $$ |   $$ |$$  _____|$$  __$$\ $$  __$$\ $$ |  $$ |$$  __$$\       $$  __$$\ \_$$  _|
$$ /  $$ |  $$ |        $$ |   $$ |$$ |      $$ |  $$ |$$ /  \__|$$ |  $$ |$$ /  \__|      $$ /  $$ |  $$ |  
$$$$$$$$ |  $$ |        \$$\  $$  |$$$$$\    $$$$$$$  |\$$$$$$\  $$ |  $$ |\$$$$$$\        $$$$$$$$ |  $$ |  
$$  __$$ |  $$ |         \$$\$$  / $$  __|   $$  __$$<  \____$$\ $$ |  $$ | \____$$\       $$  __$$ |  $$ |  
$$ |  $$ |  $$ |          \$$$  /  $$ |      $$ |  $$ |$$\   $$ |$$ |  $$ |$$\   $$ |      $$ |  $$ |  $$ |  
$$ |  $$ |$$$$$$\          \$  /   $$$$$$$$\ $$ |  $$ |\$$$$$$  |\$$$$$$  |\$$$$$$  |      $$ |  $$ |$$$$$$\ 
\__|  \__|\______|          \_/    \________|\__|  \__| \______/  \______/  \______/       \__|  \__|\______|
                                                                                                             
                                                                                                             
                           ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@"$$$$$$$$\ $$\   $$\ $$$$$$\ $$$$$$$$\                                                                        
$$  _____|$$ |  $$ |\_$$  _|\__$$  __|                                                                       
$$ |      \$$\ $$  |  $$ |     $$ |                                                                          
$$$$$\     \$$$$  /   $$ |     $$ |                                                                          
$$  __|    $$  $$<    $$ |     $$ |                                                                          
$$ |      $$  /\$$\   $$ |     $$ |                                                                          
$$$$$$$$\ $$ /  $$ |$$$$$$\    $$ |                                                                          
\________|\__|  \__|\______|   \__|  ");
                            Console.ResetColor();
                            break;
                    }


                }
            }
        }
    }
}
