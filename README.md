<!--               -->
# 複數【或稱精銳】矩陣計算求解器:Complex Matrix Solver【CMS】驗證  

## App_6J，App_6M，App_6P，App_38，App_40，App_41等6個CSharp程式碼  

### 相關的數值輸出和資料視覺化(使用Excel和Matplotlib.pyplot套件繪圖)，參見對應的App_XX儲存庫（Repository）  
<!--  

## 測試實例採用 : Dennis G. Zill, "Differential Equations with Boundary-Value Problems 9th Edition" 第322頁 至 323頁，Example 1 : Coupled Springs 作爲SMS實作驗證  

### 解此二階微分方程式，電機系的```訊號與系統```、機械系的```控制系統```、和土木系的```結構動力學```，都有相同的求解問題，使用Laplace Transform、Fourier Transform、或是Z Transform等等。而課本是使用Laplace 和 Inverse Laplace Transform求得

$$ 已知二階微分方程式 :  
\begin{bmatrix}
1 & 0 \\
0 & 1
\end{bmatrix}
\ast
\begin{bmatrix}
\ddot{y_0}(t) \\
\ddot{y_1}(t)
\end{bmatrix}
+
\begin{bmatrix}
0 & 0\\
0 & 0
\end{bmatrix}
\ast
\begin{bmatrix}
\dot{y_0}(t) \\
\dot{y_1}(t)
\end{bmatrix}
+
\begin{bmatrix}
10 & -4\\
-4 & 4
\end{bmatrix}
\ast
\begin{bmatrix}
y_0(t) \\
y_1(t)
\end{bmatrix}=
\begin{bmatrix}
0 \\
0
\end{bmatrix}
$$

$$
系統矩陣: \ \ A =
\begin{bmatrix}
-M_i\ast C & -M_i\ast K \\
I & 0  
\end{bmatrix}  
$$

$$
即 \quad A =
\begin{bmatrix}
0 & 0 & 10 & -4 \\
0 & 0 & -4 & 4 \\
1 & 0 & 0 & 0 \\
0 & 1 & 0 & 0
\end{bmatrix}  
$$  

$$
\begin{bmatrix}
\dot{y_0}(t)\\
\dot{y_1}(t)\\
y_0(t)\\
y_1(t)
\end{bmatrix}=
\begin{bmatrix}
1 \\ -1 \\ 0 \\ 0  
\end{bmatrix} 初始值@t = 0  
$$

### 空間維度【Space Dimension】有二個自由度Degree of Freedom(m = 2)，狀態維度【State Dimension】有二個自由度，即二階微分(r = 2)，時間維度【Time Dimension】是時間的函數，可以任意選取，故整個【系統矩陣】為(mXr)X(mXr)即4X4的實數矩陣，C#程式碼是引用Matrix_0類別庫，即程式碼的開頭是引用 ```using Matrix_0；```  

# 雖然系統矩陣是實數，但系統特徵值和特徵向量，其預設值(Default Value)都是複數矩陣(Complex Matrix)，請參考C#程式碼和精銳矩陣計算求解器(SMS)輸出的結果  

-->  
