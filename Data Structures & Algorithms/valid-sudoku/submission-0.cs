public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> set = new HashSet<string>();
        for(int i = 0; i<9; i ++)
        {
            for(int j = 0 ; j<9; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                else if(set.Contains(board[i][j]+"Col"+j) || set.Contains(board[i][j]+"Row"+i) || set.Contains(board[i][j]+"Box"+i/3+j/3))
                {
                    return false;
                }
                else
                {
                    set.Add(board[i][j]+"Col"+j);
                    set.Add(board[i][j]+"Row"+i);
                    set.Add(board[i][j]+"Box"+i/3+j/3);
                }
            }
        }
        return true;
    }
}
