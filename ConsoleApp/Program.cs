namespace Program.classes; 
public class ProgramGeneric<T>
{
        public T X;
        
        public ProgramGeneric(T param)
        {
        X = param;
        }
 public string? GetString()
 {
        return X?.ToString();
 }



}
