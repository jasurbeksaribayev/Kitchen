   M S B A M L   `   `   `  ����D  @WPFwithEF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFwithEF	WPFwithEF  5          WPFwithEF.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPFwithEF     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  CanteenProject��5	      $	��800��5
      $	��550��5       � 
ResizeMode$ CanMinimize=�5      
������  � WindowStartupLocation$ CenterScreen=�5      .��5      � ��5   
   �� 5       �� ImageSource$! backgroundPhoto/LagmanQ.jpg��5       �� Opacity$	 0.3Q�5       j� Stretch$
 Fill=�5       � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      �� 5       $	��220 �6   .+�5"   
   �� .+�5#      �� -   5         ��Name$ openMealPageBtn��5$      $��80��5%      $��5q�5&      $��AddMeal��5(      �� 5)      -   5        $ 
RefreshBtn��5*      $��Bottom=�5+      $��Refresh��5-      5.      � 50   
   $��1��6   .+�51      �� .+�52      ]� ���#FDFBFD$	��425��53      $
��Left=�54      .+�55      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6"      Kind$ Search=�56   "   �� 57      -   5        	 ��Name$	 SearchTxtBox��58      $��5q�59      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Search��5:      $��15(�5;      
���  ��5=      5>      �� 5?      $	��466��6   .��5@      �� -   5         ��Name$ ControllerOfMeals��5@   '   $
��Auto��5A   #   ��5B      �� 5C      .R�5D   "   A� $	��Top=�6.    A� Columns$ 2��5E   .   5F      5H      5I      5J      5K       � 5L   
   -   5          �Name$ mealPageFrame��5M      $��2��5N        � NavigationUIVisibility$ Hidden=�5O      5Q      5R      