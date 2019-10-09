using System;
using System.Collections.Generic;

class Interval: IComparable<Interval>{
    public int start { get; set; }
    public int end { get; set; }

    private Interval(){}

    public Interval(int start, int end){
        this.start = start;
        this.end = end;
    }

    public int CompareTo(Interval interval2){
        return this.start.CompareTo(interval2.start);
    }
}

class SortByEnd : IComparer<Interval>{
    public int Compare(Interval interval1, Interval interval2){
        return interval1.end.CompareTo(interval2.end);
    }
}


class Car: IComparable<Car>{
    public int price { get; set; }
    public int miles { get; set; }

    public string name { get; set; }

    private Car(){}

    public Car(int price, int miles, string name){
        this.price = price;
        this.miles = miles;
        this.name = name;
    }

    public int CompareTo(Car car2){
        return this.price.CompareTo(car2.price);
    }


}

class SortByMiles : IComparer<Car>{
    public int Compare(Car car1, Car car2){
        return car1.miles.CompareTo(car2.miles);
    }
}

