   M S B A M L   `   `   `  ����W  SText Classification Sample 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Text_Classification_Sample_1Text_Classification_Sample_1  5   	   -    'Text_Classification_Sample_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Text_Classification_Sample_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ txtInput��5
      $��Center=�6$   $��0,30,0,0q�6A    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��780��6   $��52��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgResults��5      $��10,98,10,98q�6&    J� RenderTransformOrigin$ 0.512,-0.268&�6;      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Label��6%      
IsReadOnly$
 True��64      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6e   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6F   �� 
 �� Path$
 Label�6s     5      $ Score��6%   $
 True��64   $	 130 6f   	 6G   �� $
 Score�6t   5      5      5      