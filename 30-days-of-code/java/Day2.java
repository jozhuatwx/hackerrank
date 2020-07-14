import java.util.*;

class Day2 {
    static int totalCost(double meal_cost, int tip_percent, int tax_percent) {
        // return total cost
        return (int) (meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100));
    }
    
    public static void main(String[] args) {
        // create scanner
        Scanner in = new Scanner(System.in);

        // read input
        double meal_cost = in.nextDouble();
        int tip_percent = in.nextInt();
        int tax_percent = in.nextInt();

        // close scanner
        in.close();

        // print total cost statement
        System.out.println(totalCost(meal_cost, tip_percent, tax_percent));
    }
}
