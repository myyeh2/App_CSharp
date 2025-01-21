// App50：雖然程式碼是簡單的系統，但可以推估複雜且極高頻的系統計算。
// 由系統矩陣為 A1, A2, ... A8。
// 求得對應的特徵(值)矩陣分別是D, 10^2*D, ... 10^9*D。
// 但其模態矩陣Q，則完全相同，但當系統矩陣極大時，Q是Identy矩陣。
// 個別的特徵值lamda = a + b * i，頻率 f = b / (2 * Pi) Hertz 
// 任何極高頻率 f，且|a|<0，則響應值極小。
// 公式 A * Q = Q * D  當DET(Q)不為零，則 A = Q * D * Qi，
// 用Qi而不用Q^-1是，程式變數的名稱不可用Q^-1表示，【*】是矩陣相乘的運算子。

using Matrix_0;

// Case 1 
double[,] As1 = { { 3, 4 }, { -15, -7 } };
ReMatrix A1 = new ReMatrix(As1);
EIG eig = new EIG(A1);
CxMatrix D1 = eig.CxMatrixD;
CxMatrix Q1 = eig.CxMatrixQ;
double value = (new DET(A1)).Value;
Console.Write("\n***  Case 1 ***\n");
Console.Write(" 系統矩陣 A1 :\n{0}", new PR(A1)); 
Console.Write(" 特徵矩陣 D1 :\n{0}", new PR(D1));
Console.Write(" 模態矩陣 Q1 :\n{0}", new PR(Q1));  
Console.Write(" 行列式 A1 = {0, -10}\n", value);
Console.Write("* * * * * * * * * * * * * * * * * * * * * * *\n\n");
/* Case 1 的輸出結果 ：  
***  Case 1 ***
 系統矩陣 A1 :
        3.00000          4.00000
      -15.00000         -7.00000
 特徵矩陣 D1 :
       -2.00000  +         5.91608i,        0.00000  +         0.00000i
        0.00000  +         0.00000i,       -2.00000  -         5.91608i
 模態矩陣 Q1 :
        0.45883  +         0.00000i,        0.45883  +         0.00000i
       -0.57354  +         0.67862i,       -0.57354  -         0.67862i
 行列式 A1 = 39
*/


// Case 2 
double[,] As2 = { {300, 400}, {-1500, -700} };
ReMatrix A2 = (ReMatrix)As2;
eig = new EIG(A2);
CxMatrix D2 = eig.CxMatrixD;
CxMatrix Q2 = eig.CxMatrixQ;
value = (new DET(A2)).Value;
Console.Write("\n*** Case 2 ***\n");
Console.Write(" 系統矩陣 A2 :\n{0}", new PR(A2));
Console.Write(" 特徵矩陣 D2 :\n{0}", new PR(D2));
Console.Write(" 模態矩陣 Q2 :\n{0}", new PR(Q2));
Console.Write(" 行列式 A2 = {0, -10}\n", value);
Console.Write("* * * * * * * * * * * * * * * * * * * * * * *\n\n");
/* Case 2 的輸出結果 ： 
*** Case 2 ***
 系統矩陣 A2 :
      300.00000        400.00000
    -1500.00000       -700.00000
 特徵矩陣 D2 :
     -200.00000  +       591.60798i,        0.00000  +         0.00000i
        0.00000  +         0.00000i,     -200.00000  -       591.60798i
 模態矩陣 Q2 :
        0.45883  +         0.00000i,        0.45883  +         0.00000i
       -0.57354  +         0.67862i,       -0.57354  -         0.67862i
 行列式 A2 = 390000
* * * * * * * * * * * * * * * * * * * * * * *
*/


// Case 3 
double[,] As3 = { { 3000, 4000 }, { -15000, -7000 } };
ReMatrix A3 = (ReMatrix)As3;
eig = new EIG(A3);
CxMatrix D3 = eig.CxMatrixD;
CxMatrix Q3 = eig.CxMatrixQ;
value = (new DET(A3)).Value;
Console.Write("\n*** Case 3 ***\n");
Console.Write(" 系統矩陣 A3 :\n{0}", new PR5(A3));
Console.Write(" 特徵矩陣 D3 :\n{0}", new PR5(D3));
Console.Write(" 模態矩陣 Q3 :\n{0}", new PR5(Q3));
Console.Write(" 行列式 A3 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * * *\n\n\n");
/* Case 3 的輸出結果 ： 
*** Case 3 ***
 系統矩陣 A3 :
     3.000E+003       4.000E+003
    -1.500E+004      -7.000E+003
 特徵矩陣 D3 :
    -2.000E+003  +      5.916E+003i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+003  -      5.916E+003i
 模態矩陣 Q3 :
     4.588E-001  +      0.000E+000i,     4.588E-001  +      0.000E+000i
    -5.735E-001  +      6.786E-001i,    -5.735E-001  -      6.786E-001i
 行列式 A3 = 3.9000E+007
* * * * * * * * * * * * * * * * * * * * * * *
*/


// Case 4 
double[,] As4 = { { 30000, 40000 }, { -150000, -70000 } };
ReMatrix A4 = (ReMatrix)As4;
eig = new EIG(A4);
CxMatrix D4 = eig.CxMatrixD;
CxMatrix Q4 = eig.CxMatrixQ;
value = (new DET(A4)).Value;
Console.Write("\n*** Case 4 ***\n");
Console.Write(" 系統矩陣 A4 :\n{0}", new PR5(A4));
Console.Write(" 特徵矩陣 D4 :\n{0}", new PR5(D4));
Console.Write(" 模態矩陣 Q4 :\n{0}", new PR5(Q4));
Console.Write(" 行列式 A4 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * * *\n\n\n");
/* Case 4 的輸出結果 ：  
*** Case 4 ***
 系統矩陣 A4 :
     3.000E+004       4.000E+004
    -1.500E+005      -7.000E+004
 特徵矩陣 D4 :
    -2.000E+004  +      5.916E+004i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+004  -      5.916E+004i
 模態矩陣 Q4 :
     4.588E-001  +      0.000E+000i,     4.588E-001  +      0.000E+000i
    -5.735E-001  +      6.786E-001i,    -5.735E-001  -      6.786E-001i
 行列式 A4 = 3.9000E+009
* * * * * * * * * * * * * * * * * * * * * * *
*/


// Case 5 
double[,] As5 = { { 3E05, 4E05 }, { -15E05, -7E05 } };
ReMatrix A5 = new ReMatrix(As5);
eig = new EIG(A5);
CxMatrix D5 = eig.CxMatrixD;
CxMatrix Q5 = eig.CxMatrixQ;
value = (new DET(A5)).Value;
Console.Write("\n*** Case 5 ***\n");
Console.Write(" 系統矩陣 A5 :\n{0}", new PR5(A5));
Console.Write(" 特徵矩陣 D5 :\n{0}", new PR5(D5));
Console.Write(" 模態矩陣 Q5 :\n{0}", new PR5(Q5));
Console.Write(" 行列式 A5 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * *\n\n");
/* Case 5 的輸出結果 : 
*** Case 5 ***
 系統矩陣 A5 :
     3.000E+005       4.000E+005
    -1.500E+006      -7.000E+005
 特徵矩陣 D5 :
    -2.000E+005  +      5.916E+005i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+005  -      5.916E+005i
 模態矩陣 Q5 :
     1.000E+000  +      0.000E+000i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,     1.000E+000  +      0.000E+000i
 行列式 A5 = 3.9000E+011
* * * * * * * * * * * * * * * * * * * * * *
*/


// Case 6 
double[,] As6 = { {3E06, 4E06}, {-15E06, -7E06} };
ReMatrix A6 = (ReMatrix)As6;
eig = new EIG(A6);
CxMatrix D6 = eig.CxMatrixD;
CxMatrix Q6 = eig.CxMatrixQ;
value = (new DET(A6)).Value;
Console.Write("\n*** Case 6 ***\n");
Console.Write(" 系統矩陣 A6 :\n{0}", new PR5(A6));
Console.Write(" 特徵矩陣 D6 :\n{0}", new PR5(D6));
Console.Write(" 模態矩陣 Q6 :\n{0}", new PR5(Q6));
Console.Write(" 行列式 A6 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * *\n\n");
/*Case 6 的輸出結果 : 
*** Case 6 ***
 系統矩陣 A6 :
     3.000E+006       4.000E+006
    -1.500E+007      -7.000E+006
 特徵矩陣 D6 :
    -2.000E+006  +      5.916E+006i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+006  -      5.916E+006i
 模態矩陣 Q6 :
     1.000E+000  +      0.000E+000i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,     1.000E+000  +      0.000E+000i
 行列式 A6 = 3.9000E+013
* * * * * * * * * * * * * * * * * * * * * *
*/


// Case 7 
double[,] As7 = { {3E07, 4E07}, { -15E07, -7E07} };
ReMatrix A7 = (ReMatrix)As7;
eig = new EIG(A7);
CxMatrix D7 = eig.CxMatrixD;
CxMatrix Q7 = eig.CxMatrixQ;
value = (new DET(A7)).Value;
Console.Write("\n*** Case 7 ***\n");
Console.Write(" 系統矩陣 A7 :\n{0}", new PR5(A7));
Console.Write(" 特徵矩陣 D7 :\n{0}", new PR5(D7));
Console.Write(" 模態矩陣 Q7 :\n{0}", new PR5(Q7));
Console.Write(" 行列式 A7 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * *\n\n");
/* Case 7 的輸出結果 ： 
*** Case 7 ***
 系統矩陣 A7 :
     3.000E+007       4.000E+007
    -1.500E+008      -7.000E+007
 特徵矩陣 D7 :
    -2.000E+007  +      5.916E+007i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+007  -      5.916E+007i
 模態矩陣 Q7 :
     1.000E+000  +      0.000E+000i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,     1.000E+000  +      0.000E+000i
 行列式 A7 = 3.9000E+015
* * * * * * * * * * * * * * * * * * * * * *
*/


// Case 8 
double[,] As8 = { {3E9, 4E9}, {-15E9, -7E9} };
ReMatrix A8 = new ReMatrix(As8);
eig = new EIG(A8);
CxMatrix D8 = eig.CxMatrixD;
CxMatrix Q8 = eig.CxMatrixQ;
value = (new DET(A8)).Value;
Console.Write("\n*** Case 8 ***\n");
Console.Write(" 系統矩陣 A8 :\n{0}", new PR5(A8));
Console.Write(" 特徵矩陣 D8 :\n{0}", new PR5(D8));
Console.Write(" 模態矩陣 Q8 :\n{0}", new PR5(Q8));
Console.Write(" 行列式 A8 = {0, -10}\n", value.ToString("E4"));
Console.Write("* * * * * * * * * * * * * * * * * * * * * *\n\n");
/* Case 8 的輸出結果 : 
*** Case 8 ***
 系統矩陣 A8 :
     3.000E+009       4.000E+009
    -1.500E+010      -7.000E+009
 特徵矩陣 D8 :
    -2.000E+009  +      5.916E+009i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,    -2.000E+009  -      5.916E+009i
 模態矩陣 Q8 :
     1.000E+000  +      0.000E+000i,     0.000E+000  +      0.000E+000i
     0.000E+000  +      0.000E+000i,     1.000E+000  +      0.000E+000i
 行列式 A8 = 3.9000E+019
* * * * * * * * * * * * * * * * * * * * * *
*/
