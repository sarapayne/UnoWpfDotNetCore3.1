   M S B A M L   `   `   `  ���� >  :Uno, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Uno.ViewUno.View  !    Uno.View.WpfWindowSetupGame   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Uno.View       � Title$  WpfWindowSetupGame��$	��450��$
��1200��.��� -    �Name$ 	OuterGrid�� � ColumnDefinitions �� $��20 ��� $��2* ��� $��* ��� $��2* ��� $��20 � � RowDefinitions �� $��20 ��� $��* ��� $
��auto ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $
��auto ��� $��20 �.+��� -    ��Name$ buttonStart��$��	StartGame��$��2��$��7��$��10q�$��20(�${�false���� -   $ buttonMainMenu��$��	Main Menu��$��1��$��1��$��10q�$��20(�$
{�True���� -   $ buttonAddPlayer��$��
Add Player��$��1��$��4��$��10q�$��20(�${�false���� -    ��Name$ listboxNames��$��1��$��2��$��6��$��10q��� -    ��Name$ labelEnterName��$��Enter Player Name��$��1��$��2��$��40(�$��Center=��� -    ��Name$ textboxEnterName��$��1��$��3��$��20(�$	��...��$��10q�$
{�True��� -   $ LeftSide��$��5��$��1��$��3��$��10q� �� $��* ��� $��* � �� $��* ��� $��* ��� $��* �.+�	� -	    	�Name$ radioOfficialRules��$��Official Rules��$��0��$��0��$��30(�	 d� 	IsChecked$
	 TrueY�$
��Left=�$��Center=�	� -
   $ radioHouseRules1��$��House Rules1��$��0��$��1��$��30(�$	 FalseY�$
��Left=�$��Center=�	� -   $ radioHouseRules2��$��House Rules2��$��0��$��2��$��30(�$	 FalseY�$
��Left=�$��Center=�	� -   $ radioHouseRules3��$��House Rules3��$��1��$��0��$��30(�$	 FalseY�$
��Left=�$��Center=�� -   $ 	RightSide��$��3��$��1��$��7��$��10q� �� $��* ��� $��* ��� $��* ��� $��* � �� $��4* ��� $
��auto ��� $��* ��� $��* �.+��� $.��(/Resources/card_front_wild_swaphands.png��$��2��$��1���� -   
 ��Name$
 checkBoxSwapHands��$��1��$��1��$��2��$��Include��$��Center=�$��Center=�$��30(��� -   $ labelHowMany��$��0��$��2��$��4��$,��&Please Select The Number Of Wild Cards��$��25(�$��Center=�$��Center=�	� -   $ 
radio1Card��$��0��$��3��$��1��$��Center=�$��Bottom=�$��30(�$
	 TrueY�${�False��	� -   $ 
radio2Card��$��1��$��3��$��2��$��Center=�$��Bottom=�$��30(�${�False��	� -   $ 
radio3Card��$��2��$��3��$��3��$��Center=�$��Bottom=�$��30(�${�False��	� -   $ 
radio4Card��$��3��$��3��$��4��$��Center=�$��Bottom=�$��30(�${�False��