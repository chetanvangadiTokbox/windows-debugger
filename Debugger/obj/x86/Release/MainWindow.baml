   M S B A M L   `   `   `  ���� K  GWPFVideoRenderer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;/clr-namespace:OpenTok;assembly=WPFVideoRendererOpenTok  C ?Debugger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DebuggerDebugger    Debugger.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     COpenTok/clr-namespace:OpenTok;assembly=WPFVideoRenderer     (localclr-namespace:Debugger       � Title$  
MainWindow��$��705.143��$��1095.429��.��]� ��.  ���#F2F1EE$��0,0,-113.286,-209.429q�.+��� $	��Top=�$��0,0,0,0q�$��50��#��� �� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ image��$��45��$��Resources/tokbox.png��$
��Left=� J� IsHitTestVisible .  $	��180��$��20,5,0,0q� J� IsManipulationEnabled . �� -    ��Name$ Debugger��$��Debugger��$��0,0,0,0q�$��50��#��� ��$��30(�$��Expanded&�$��Stretch=�$��Center=�$��Light"�$��
Nirmala UI)��� $
��Left=�$��5,5,0,0q�$	��200�����	#FFF9F9F9.+�]� ��.  ���	#FFF9F9F9.+��� $	��Top=����	#FFF9F9F9.+��� -    ��Name$ create_session��$��Create Session��$
��Left=�$��	19,15,0,0q�$	��Top=�$	��160�����	#FF69B6E5$��0q�$��40�� � UseLayoutRounding .  �� -   $ connect_button��$��Connect��$
��Left=�$��	19,10,0,0q�$	��Top=�$	��160�����	#FF69B6E5$��40��$��0q��� -   $ publisher_button��$��Publish��$
��Left=�$��	19,10,0,0q�$	��Top=�$	��160�����	#FF69B6E5$��40��$��0q��� -   $ publihser_audio_button��$
��Left=�$��26��$��	19,10,0,0q�$	��Top=�$��28��$#��Resources/publisher_audio.png���� $	��Top=����	#FFF9F9F9$��	0,136,0,0q�.+��� -   $ subscriber_button��$��	Subscribe��$
��Left=�$��	19,10,0,0q�$��Bottom=�$	��160�����	#FF69B6E5$��40���� -   $ subscriber_audio_button��$
��Left=�$��26��$��	19,10,0,0q�$��Bottom=�$��28��$$��Resources/subscriber_audio.png���� $
��Left=�$	��300�����#F2F1EE.+�]� ��.  ���#F2F1EE.+��� $	��Top=����#F2F1EE.+�   OpenTok.VideoRenderer  -	     Name$ publisherVideo��$
��Left=�$	��200��$	��top=�$	��300��$��0,18,10.429,10.143q����	#FF5B1919$��1q�	 J� Effect	 3  -System.Windows.Media.Effects.DropShadowEffect  
   Opacity$	
 0.6Q�����  j� Stretch$ UniformToFill=��� $	��Top=����#F2F1EE$��	0,113,0,0q�.+�  -
   $ subscriberVideo��$
��Left=�$	��200��$	��Top=�$	��300��$��0,0,10.429,10.143q����	#FF5B1919$��1q�	   $	
 0.6Q����� $ UniformToFill=��� -    ��Name$ sessionInfo��$
��Left=�$	��390�����#F2F1EE.+�]� ��.  ���#F2F1EE.+��� $	��Top=����#F2F1EE.+�� .+�,� -    ,�Name$ publisherDataTable��" ,� VerticalScrollBarVisibility$
 Auto=�.��/� .T��� .r��� -   $��PublisherData��$��0q�$	��200��$	��400�� �� View �� -   publisherGrid��.P���  �� Width$	 100�� �� DisplayMemberBinding �� *Field+�� $��Publisher Info��$	 278�� �� CellTemplate �� .R�� .+��� $	��278�� �� 
IsReadOnly . ���� *Value+�� $	��Top=����#F2F1EE.+�� .+�,� -   $ subscriberDataTable��$
 Auto=�.��/� .T��� .r��� -   $��SubscriberData��$��0q�$	��200��$	��400��$��0,87,0,0q� �� .P��� $	 100�� �� *Field+�� $��Subscriber Info��$	 278�� �� .R�� .+��� $	��278�� . ���� *Value+