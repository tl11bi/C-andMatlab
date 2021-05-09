%--------------------------------------------------------
function [addRlt,minusRlt]=MatrixOpera(a,b)
% 矩阵相加,相减
[m1,n1]=size(a);
[m2,n2]=size(b);
if m1~=m2 || n1~=n2
    display('矩阵大小不相同')
    error('参数错误');
end
addRlt=a+b;
minusRlt=a-b;
end
%-----------------------------------------------------------