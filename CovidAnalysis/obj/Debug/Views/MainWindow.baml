   M S B A M L   `   `   `  ����  CovidAnalysis$    CovidAnalysis.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Y UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5   	   $	��350��5   !   $	��610��6.    � Title 6	   �� *Title+.��5      �� $
��Auto=�6   .��5	   
   ��  �� CanVerticallyScroll . .+�5
      �� -   5        $��	ComboBox1��5
   s   $��
10,10,0,13q�6_   $
��Left=�6�   $	��Top=�5      $	��194��6'   $��30��63   5      � 5       � ColumnDefinitions 5      �� 5      �� 5      $��0* �6'   .+�5      �� !  Prism.Regions.RegionManager   
RegionName$ ContentRegion��6!   $��0,0,0.4,-0.2q�6P   &   System.Windows.Controls.DataGrid  5      -   5        $��dataGrid��5   L      AlternatingRowBackground
 ��ح� �� AlternationCount$ 2��5         AutoGenerateColumns .  $��0,0,-85.6,-0.2q�6I   $
��Left=�6a   $
��Auto��6|   $��2��6�   "   VerticalScrollBarVisibility$ Visible=�6�   ��5      �� *VaccinationDataToDisplay+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Date��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
DateTime+  5      $
 State��6-    6>   �� *State+  5      $
 Total Vaccinated��6-    6I   �� *TotalVaccinated+  5      $
 
First Dose��6-    6C   �� *	FirstDose+  5      $
 Second Dose��6-    6D   �� *
SecondDose+  5      $
 Covaxin��6-    6@   �� *	Covaxin+  5      $
 
Covishield��6-    6C   �� *
Covishield+  5      $
 18 age group��6-    6E   �� *_18+  5      $
 45 age group��6-    6E   �� *_45+5#      5$      5&      5'      5(      