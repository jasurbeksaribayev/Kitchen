   M S B A M L   `   `   `  ����D  @WPFwithEF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFwithEF.PagesWPFwithEF.Pages  5      $    WPFwithEF.Pages.MealUpdatePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WPFwithEF.Pages     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  MealUpdatePage��5	       N� 
Background
 ����  � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       ']� n     �� 5   
   " ��6   .�5      ��  � ��$ 50��6'   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ]�6   .�5      ��  � ��$ 5q�6'   �� 5       � ��
 �����6+   5      5      .��5      � .+�5   
   �� $	��220��6   $��Center=�6!   .+�5      �� $��60��5      $��50��5      $��5q�5       
�������$��2q�5"      ._�5#      �� -   5         ��Name$ ImageMealAdd��5$      $��60��5%      $��50��5&      5'      ]� 5(      .+�5)      '  !MaterialDesignThemes.Wpf.PackIcon  $��25��5*      $��25��5+      $��Center=�5,         Kind$ 
Identifier=�5-      �� 5.      -   5         ��Name$ MealId��5/      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Meal Id��50      
 �� 
IsReadOnly$

 True��51       !  MaterialDesignOutlinedTextBox#��[  52      53      ]� 54      .+�55        $��25��56      $��25��57      $��Center=�58      $ FoodItalian=�59      �� 5:      -   5        $ MealName��5;      $	 	Meal name��5<      $

 True��5=      #��[  5>      5?      ]� 5@      .+�5A        $��25��5B      $��25��5C      $��Center=�5D      $ Dollar=�5E      �� 5F      -   5        $ MealCost��5G      $	 	Meal cost��5H      $

 True��5I      #��[  5J      5K      ]� 5L      .+�5M        $��25��5N      $��25��5O      $��Center=�5P      $ 
AccessTime=�5Q      �� 5R      -   5        $ MealCreationTime��5S      $	 Meal creation time��5T      $

 True��5U      #��[  5V      5W      ]� 5X      .+�5Y        $��25��5Z      $��25��5[      $��Center=�5\      $ Update=�5]      �� 5^      -   5        $ MealUpdatedTime��5_      $	 Meal updated time��5`      $

 True��5a      #��[  5b      5c      ]� 5d      .+�5e        $��25��5f      $��25��5g      $��Center=�5h      $ FileExchange=�5i      �� 5j      -   5         ��Name$ 	DeleteBtn��5k      $��90��5l      $��Delete��5n      $��12(�5o      �� 5p      -   5        $ 	UpdateBtn��5q      $��90��5r      $��Update��5t      $��12(�5u      5v      5w      5x      5y      