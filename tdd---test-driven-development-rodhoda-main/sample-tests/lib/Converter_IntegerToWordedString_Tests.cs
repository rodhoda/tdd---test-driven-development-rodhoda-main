namespace sample_tests;
using Xunit;
using sample.lib;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;


public class Convert_IntegerToWordedString_Tests
{
    [Fact]
    //TODO: This test will become obsolete if the featured function is fully implemented.
    public void NotImplementedYet()
    {
        Action act = () => Converter.IntegerToWordedString(int.MinValue);
        Assert.Throws<NotImplementedException>(act);
    }

//  Single Digit Unit Testing
    [Fact]
    public void SinglesDigitFirstTest() {
        int number = 1;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("one",words,true);
    }
    [Fact]
    public void SinglesDigitSecondEdgeTest() {
        int number = 9;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("nine",words,true);
    }
    [Fact]
    public void SinglesDigitThirdEdgeTest() {
        int number = 0;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("zero",words,true);
    }

//  Teens Digit Unit Testing
    [Fact]
    public void TeensDigitFirstEdgeTest()   {
        int number = 19;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("nineteen", words, true);
    }
    [Fact]
    public void TeensDigitSecondEdgeTest()   {
        int number = 10;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("ten", words, true);
    }
    [Fact]
    public void TeensDigitThirdTest()   {
        int number = 11;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("eleven", words, true);
    }


    // Double Digit Unit Testing
    [Fact]
    public void DoubleDigitFirstTest()   {
        int number = 24;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("twenty-four", words, true);
    }
    [Fact]
    public void DoubleDigitSecondTest()   {
        int number = 99;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("ninety-nine", words, true);
    }
    [Fact]
    public void DoubleDigitThirdTest()   {
        int number = 70;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("seventy-zero", words, true);
    }


    // Triple Digit Unit Testing
    [Fact] 
    public void TripleDigitFirstTest() {
        int number = 115;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("one hundred and fifteen",words, true);
    }
    [Fact] 
    public void TripleDigitSecondTest() {
        int number = 641;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("six hundred and forty-one",words, true);
    }
    [Fact] 
    public void TripleDigitThirdTest() {
        int number = 999;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("nine hundred and ninety-nine",words, true);
    }
    
}