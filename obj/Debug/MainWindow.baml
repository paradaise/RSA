   M S B A M L   `   `   `  ����  RSA    RSAEncryptionApp.MainForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  RSA Encryption App��5   	   $	��400��6$   $	��600��61    � 
ResizeMode$ NoResize=�5   	   .��5      � .+�5   
   �� $��Alice's Message:��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   �� 5	   
   -   5         ��Name$ AliceMessageTextBox��5	      $
��Left=�6/   $��30��6J   $��	10,35,0,0q�6V   $	��Top=�6i   $	��200��6�   �� 5
   
   -   5        $��Send Message��5
      $
��Left=�6(   $��	10,75,0,0q�6C   $	��Top=�6V   $	��200��6n   6z   �� 5   
   $��Bob's Encrypted Message:��6   $
��Left=�63   $��
330,10,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $  BobEncryptedMessageTextBox��5      $
��Left=�66   $��30��6Q   $��
330,35,0,0q�6]   $	��Top=�6q   $	��200��6�   �� 5   
   $��Bob's Decrypted Message:��6   $
��Left=�63   $��
330,75,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $  BobDecryptedMessageTextBox��5      $
��Left=�66   $��30��6Q   $��330,100,0,0q�6]   $	��Top=�6r   $	��200��6�   �� 5   
   -   5        $��Decrypt Bob's Message��5      $
��Left=�61   $��330,150,0,0q�6L   $	��Top=�6a   $	��200��6y   6�   �� 5   
   $��Bob's Message:��6   $
��Left=�6)   $��
10,200,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $ BobMessageTextBox��5      $
��Left=�6-   $��30��6H   $��
10,225,0,0q�6T   $	��Top=�6h   $	��200��6�   �� 5   
   -   5        $��Send Message��5      $
��Left=�6(   $��
10,265,0,0q�6C   $	��Top=�6W   $	��200��6o   6{   �� 5   
   $ ��Alice's Encrypted Message:��6   $
��Left=�65   $��330,200,0,0q�6P   $	��Top=�6e   �� 5   
   -   5        $" AliceEncryptedMessageTextBox��5      $
��Left=�68   $��30��6S   $��330,225,0,0q�6_   $	��Top=�6t   $	��200��6�   �� 5   
   $ ��Alice's Decrypted Message:��6   $
��Left=�65   $��330,265,0,0q�6P   $	��Top=�6e   �� 5   
   -	   5        $" AliceDecryptedMessageTextBox��5      $
��Left=�68   $��30��6S   $��330,290,0,0q�6_   $	��Top=�6t   $	��200��6�   �� 5   
   -
   5        $��Decrypt Alice's Message��5      $
��Left=�63   $��330,330,0,0q�6N   $	��Top=�6c   $	��200��6{   6�   5      5      