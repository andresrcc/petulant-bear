 s i n g   S y s t e m ; 
 
 u s i n g   S y s t e m . I O ; 
 
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ; 
 
 
 
 n a m e s p a c e   F i n d D i g i t s 
 
 { 
 
 	 c l a s s   M a i n C l a s s 
 
 	 { 
 
 	 	 s t a t i c   v o i d   P r i n t D i g i t s ( i n t [ ]   d i g i t C o u n t s ) { 
 
 	 	 	 f o r   ( i n t   i   =   0 ;   i   <   d i g i t C o u n t s . L e n g t h ;   i + + )   { 
 
 	 	 	 	 C o n s o l e . W r i t e L i n e   ( d i g i t C o u n t s   [ i ] ) ; 
 
 	 	 	 } 
 
 	 	 } 
 
 
 
 	 	 s t a t i c   i n t   D i v i d e B y D i g i t s ( s t r i n g   n u m b e r ) { 
 
 
 
 	 	 	 S t r i n g R e a d e r   s r   =   n e w   S t r i n g R e a d e r   ( n u m b e r ) ; 
 
 	 	 	 i n t   d i g i t ; 
 
 	 	 	 i n t   q u a n t i t y   =   C o n v e r t . T o I n t 3 2 ( n u m b e r ) ; 
 
 	 	 	 i n t   c o u n t   =   0 ; 
 
 
 
 	 	 	 f o r ( i n t   i   =   0 ;   i   <   n u m b e r . L e n g t h ;   i + + ) { 
 
 	 	 	 	 d i g i t   =   i n t . P a r s e ( ( s t r i n g ) s r . R e a d ( ) ) ;   / / f i x ! 
 
 	 	 	 	 i f   ( ( q u a n t i t y   %   d i g i t )   = =   0 )   { 
 
 	 	 	 	 	 c o u n t + + ; 
 
 	 	 	 	 } 
 
 	 	 	 } 
 
 	 	 	 r e t u r n   c o u n t ; 
 
 	 	 } 
 
 
 
 	 	 s t a t i c   i n t [ ]   F i n d D i g i t s ( s t r i n g [ ]   p a r a m e t e r s ) { 
 
 	 	 	 i n t   c a s e s   =   C o n v e r t . T o I n t 3 2   ( p a r a m e t e r s   [ 0 ] ) ; 
 
 	 	 	 i n t [ ]   d i g i t s   =   n e w   i n t [ c a s e s ] ; 
 
 
 
 	 	 	 f o r   ( i n t   i   =   1 ;   i   <   c a s e s ;   i + + )   { 
 
 	 	 	 	 d i g i t s   [ i ]   =   D i v i d e B y D i g i t s   ( p a r a m e t e r s [ i ] ) ; 
 
 	 	 	 } 
 
 	 	 	 r e t u r n   d i g i t s ; 
 
 	 	 } 
 
 	 	 p u b l i c   s t a t i c   v o i d   M a i n   ( s t r i n g [ ]   a r g s ) 
 
 	 	 { 
 
 	 	 	 i n t [ ]   d i g i t C o u n t s   =   F i n d D i g i t s   ( a r g s ) ; 
 
 	 	 	 P r i n t D i g i t s   ( d i g i t C o u n t s ) ; 
 
 	 	 } 
 
 	 } 
 
 } 
 
 