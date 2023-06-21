// 與第App_6J測試相同，僅提供邊界值條件是 : 
// t=4.5， y0=[-0.68877 | -1.37729]
// t=16.5，y1=[0.11710  |  0.23071]。
using System;
using Matrix_0; 

namespace ConsoleApp6M
{
    internal class Program
    {
        static void Main(string[] args)
        {

    // 已知邊界條件，其向量為BVal
    // 邊界值 @t = 4.5 
    double[,] y0 = { { -0.68877 }, { -1.37729 } };
    // 邊界值 @t = 16.5 
    double[,] y1 = { { 0.11710 }, { 0.23071 } };
    ReMatrix BVal = (ReMatrix)y0 | y1; 

    // 已知陣列 M, K, and C 
    double[,] M = { { 2, 0 }, { 0, 1 } };
    double[,] K = { { 3, -1 }, { -1, 1 } };
    double[,] C = { { 0.4, -0.05 }, { -0.05, 0.2 } };

    // 建構系統矩陣A : 
    ReMatrix Mi = ~(ReMatrix)M; 
    Iden iden = new Iden(2);
    ReMatrix I = iden.Matrix;
    Zero zero = new Zero(2);
    ReMatrix O = zero.Matrix;
    ReMatrix A = ((-1.0 * Mi * C) & (-1.0 * Mi * K)) | (I & O);

    // 系統與狀態係數。
    // 特徵值矩陣D和特徵向量矩陣Q。
    EIG eig = new EIG(A);
    CxMatrix D = eig.CxMatrixD;
    CxMatrix V = eig.CxVector;
    CxMatrix Q = eig.CxMatrixQ;
    // 係數向量d。 
    CxToHexp Hexp = new CxToHexp(D, Q, 4.5);
    CxMatrix MatTemp = Hexp.GetCxMatrix;
    RowSlice rowSlice = new RowSlice(MatTemp, 2, 1);
    CxMatrix Mat1 = rowSlice.GetCxMatrix;

    Hexp = new CxToHexp(D, Q, 16.5);
    MatTemp = Hexp.GetCxMatrix; 
    rowSlice = new RowSlice(MatTemp, 2, 1);
    CxMatrix Mat2 = rowSlice.GetCxMatrix;

    // 矩陣Mat1和矩陣Mat2垂直合併。
    CxMatrix Mat = Mat1 | Mat2;
    CxMatrix d = ~ Mat * BVal; 

    // 列印標題。
    Console.Write("\n****{0,6}系{0,4}統{0,4}與{0,4}狀{0,4}態{0,4}參{0,4}數{0,6}****\n", "");

    // 列印系統與狀態參數。
    Console.Write("\n***{0,5}特徵值V{0,5}***\n{1}\n", "", new PR(V));
    Console.Write("\n***{0,5}特徵向量矩陣Q{0,5}***\n{1}\n", "", new PR(Q));
    Console.Write("\n***{0,5}係數向量d{0,5}***\n{1}\n", "", new PR(d));

        }
    }
}
/*
****      系    統    與    狀    態    參    數      ****

***     特徵值V     ***
    -0.11666  +    1.40933i
    -0.11666  -    1.40933i
    -0.08334  +    0.70221i
    -0.08334  -    0.70221i

***     特徵向量矩陣Q     ***
   0.57745 +   0.00000i,   0.57745 +   0.00000i,  
   0.25800 +   0.00000i,   0.25800 +   0.00000i

  -0.57707 -   0.01365i,  -0.57707 +   0.01365i,  
   0.51648 -   0.00609i,   0.51648 +   0.00609i

  -0.03369 -   0.40695i,  -0.03369 +   0.40695i,  
  -0.04300 -   0.36231i,  -0.04300 +   0.36231i

   0.02405 +   0.40748i,   0.02405 -   0.40748i,   
  -0.09463 -   0.72428i,  -0.09463 +   0.72428i

***     係數向量d     ***
    0.00484 +   0.00005i
    0.00484 -   0.00005i
   -0.01085 +   1.37914i
   -0.01085 -   1.37914i

請按任意鍵繼續 . . .
*/
