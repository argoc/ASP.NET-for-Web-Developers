using System;

/// <summary>
/// An object of StatCalc can be used to gather statistics about numbers
/// that are entered. The enter(double) method adds the numbers to those
/// already evaluated. You can get the current statistics with the properties,
/// which provide them in getters.
/// </summary>
public class StatCalc {

    private double squareSum;
     
    /// Add a number to the dataset.  The statistics will be computed for all
    /// the numbers that have been added to the dataset using this method.
    public void enter(double num) {
        Count++;
        Sum += num;
        squareSum += num * num;
    }

    /// Return the number of items that have been entered into the dataset.
    public int Count { get; set; }

    /// Return the sum of all the numbers that have been entered.
    public double Sum { get; set; }

    /// Return the average of all the items that have been entered.
    /// The return value is Double.NaN if no numbers have been entered.
    public double Mean { 
        get { return Sum / Count; }
    }

    /// Return the standard deviation of all the items that have been entered.
    /// The return value is Double.NaN if no numbers have been entered.
    public double StandardDeviation { 
        get {
            if (Count == 0)
                return Double.NaN;
            return Math.Sqrt(squareSum / Count - Mean * Mean);
        }
    }

}  // end class StatCalc
