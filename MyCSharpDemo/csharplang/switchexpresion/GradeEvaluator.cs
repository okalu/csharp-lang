// Switch Expression
using System.Security.Cryptography;

public class GradeEvaluator {


    public static string evalGrade(int score) {
        return score switch {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }
    
}