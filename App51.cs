using Matrix_0;

// 複數矩陣 A
double[,] Re1 = { {8, 7, 6}, {4, -5, 9}, {9, 0, 3} };
double[,] Cx1 = { {6, 1, -9}, {-4, 9, -1}, {12, 8, -8} };
CxMatrix A = new CxMatrix(Re1, Cx1);
Console.Write("\n Matrix A :\n{0}\n", new PR(A));
/* 複數矩陣A
 Matrix A :
8.00000 +  6.00000i,   7.00000 +  1.00000i,  6.00000 - 9.00000i
4.00000 -  4.00000i,  -5.00000 +  9.00000i,  9.00000 - 1.00000i
9.00000 + 12.00000i,   0.00000 +  8.00000i,  3.00000 - 8.00000i
*/


// 複數矩陣A的逆矩陣B  
CxMatrix B = ~A; 
Console.Write("\n Matrix B = Ai \n{0}\n", new PR(B));
/*
 Matrix B = Ai
0.02150 -  0.00001i,   0.01423 +  0.04576i,  0.00992 -   0.04156i
0.04278 +  0.06708i,  -0.03746 -  0.02003i, -0.03442 -   0.05000i
0.07987 +  0.01292i,   0.04172 +  0.01695i, -0.05763 +   0.02312i
*/


// 複數矩陣C = Id = A * Ai
CxMatrix C = A * B;
Console.Write("\n Matrix C\n{0}\n", new PR(C));
/*
 Matrix C
 1.00000 +  0.00000i,  0.00000 +  0.00000i,  0.00000 +   0.00000i
 0.00000 +  0.00000i,  1.00000 +  0.00000i,  0.00000 +   0.00000i
 0.00000 +  0.00000i,  0.00000 +  0.00000i,  1.00000 +   0.00000i
*/


// 將複數轉為實數矩陣 Id(Identity Matrix) 
ReMatrix D = (ReMatrix)C;
Console.Write("\n Matrix D :\n{0}\n", new PR(D));
/*
 Matrix D :
        1.00000          0.00000          0.00000
        0.00000          1.00000          0.00000
        0.00000          0.00000          1.00000
*/


// 對稱矩陣As的模態矩陣Q，則矩陣Q的逆矩陣Qi與轉置矩陣Qt相等。
double[,] As = { {3, -4, 9}, {-4, 6, -2}, {9, -2, 7} };
ReMatrix Q = (new EIG(As)).MatrixQ;
ReMatrix Qi = ~Q;   //逆矩陣Qi
ReMatrix Qt = !Q;   //轉置矩陣Qt
Console.Write("\n 逆矩陣 Matrix Qi  :\n{0}\n", new PR(Qi));
Console.Write("\n 轉置矩陣 Matrix Qt :\n{0}\n", new PR(Qt));
/*
 逆矩陣 Matrix Qi :
        0.60499         -0.38472          0.69712
        0.09218          0.90348          0.41860
        0.79088          0.18899         -0.58206
 轉置矩陣 Matrix Qt :
        0.60499         -0.38472          0.69712
        0.09218          0.90348          0.41860
        0.79088          0.18899         -0.58206
*/
