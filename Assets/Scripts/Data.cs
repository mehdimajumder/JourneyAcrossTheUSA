using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    //ID, random version, trivia
    Dictionary<int, string> states = new Dictionary<int, string>();
    Dictionary<int, string> quizOption = new Dictionary<int, string>();
    public static Dictionary<int, string> oldQuestion = new Dictionary<int, string>();

    static public int currentQuestion;
    static public bool complete;
    static public int currentMainQuestion = 0;
    static public int currentQuizQuestion = 0;
    static public int amountOfQuestions;
    static public int levelPoints;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
       generateQuestion();
        //Game dictionary
       states.Add(1, "NEW YORK, STATE CAPITAL: ALBANY, SLOGAN: THE \"EMPIRE STATE\", STATE FLOWER: ROSE, RATIFIED: JUL 26 1788,Flags/NEWYORK");
       states.Add(2, "ALABAMA, STATE CAPITAL: MONTGOMERY, SLOGAN: THE \"HEART OF DIXIE\", STATE FLOWER: CAMELLIA, RATIFIED: DEC 14 1819,Flags/ALABAMA");
       states.Add(3, "ALASKA, STATE CAPITAL: JUNEAU, SLOGAN: THE \"LAST FRONTIER\", STATE FLOWER: FORGET-ME-NOT, RATIFIED: JAN 3 1959,Flags/ALASKA");
       states.Add(4, "ARIZONA, STATE CAPITAL: PHOENIX, SLOGAN: THE \"GRAND CANYON STATE\", STATE FLOWER: SAGUARO CACTUS BLOSSOM, RATIFIED: FEB 14 1912,Flags/ARIZONA");
       states.Add(5, "ARKANSAS, STATE CAPITAL: LITTLE ROCK, SLOGAN: THE \"NATURAL STATE\", STATE FLOWER: APPLE BLOSSOM, RATIFIED: JUN 15 1836,Flags/ARKANSAS");
       

       states.Add(6, "CALIFORNIA, STATE CAPITAL: SACREMENTO, SLOGAN: THE \"GOLDEN STATE\", STATE FLOWER: GOLDEN POPPY, RATIFIED: SEP 9 1850,Flags/CALIFORNIA");
       states.Add(7, "COLORADO, STATE CAPITAL: DENVER, SLOGAN: THE \"CENTENNIAL STATE\", STATE FLOWER: ROCKY MOUNTAIN COLUMBINE, RATIFIED: AUG 1 1876,Flags/COLORADO");
       states.Add(8, "CONNECTICUT, STATE CAPITAL: HARTFORD, SLOGAN: THE \"CONSTITUTION STATE\", STATE FLOWER: MOUNTAIN LAUREL, RATIFIED: JAN 9 1788,Flags/CONNECTICUT");
       states.Add(9, "DELAWARE, STATE CAPITAL: DOVER, SLOGAN: THE \"FIRST STATE\", STATE FLOWER: PEACH BLOSSOM, RATIFIED: DEC 7 1787,Flags/DELAWARE");
       states.Add(10, "FLORIDA, STATE CAPITAL: TALLAHASSEE, SLOGAN: THE \"SUNSHINE STATE\", STATE FLOWER: ORANGE BLOSSOM, RATIFIED: MAR 3 1845,Flags/FLORIDA");

       states.Add(11, "GEORGIA, STATE CAPITAL: ATLANTA, SLOGAN: THE \"PEACH STATE\", STATE FLOWER: CHEROKEE ROSE, RATIFIED: JAN 2 1788,Flags/GEORGIA");
       states.Add(12, "HAWAII, STATE CAPITAL: HONOLULU, SLOGAN: THE \"ALOHA STATE\", STATE FLOWER: HIBISCUS, RATIFIED: AUG 21 1959,Flags/HAWAII");
       states.Add(13, "IDAHO, STATE CAPITAL: BOISE, SLOGAN: THE \"GEM STATE\", STATE FLOWER: SYRINGA, RATIFIED: JULY 3 1890,Flags/IDAHO");
       states.Add(14, "ILLINOIS, STATE CAPITAL: SPRINGFIELD, SLOGAN: THE \"LAND OF LINCOLN\", STATE FLOWER: VIOLET, RATIFIED: DEC 3 1818,Flags/ILLINOIS");
       states.Add(15, "INDIANA, STATE CAPITAL: INDIANAPOLIS, SLOGAN: THE \"HOOSIER STATE\", STATE FLOWER: PEONY, RATIFIED: DEC 11 1816,Flags/INDIANA");

       states.Add(16, "IOWA, STATE CAPITAL: DES MOINES, SLOGAN: THE \"HAWKEYE STATE\", STATE FLOWER: PRAIRIE ROSE, RATIFIED: DEC 28 1846,Flags/IOWA");
       states.Add(17, "KANSAS, STATE CAPITAL: TOPEKA, SLOGAN: THE \"SUNFLOWER STATE\", STATE FLOWER: SUNFLOWER, RATIFIED: JAN 29 1861,Flags/KANSAS");
       states.Add(18, "KENTUCKY, STATE CAPITAL: FRANKFORT, SLOGAN: THE \"BLUEGRASS STATE\", STATE FLOWER: GOLDENROD, RATIFIED: JUN 1 1792,Flags/KENTUCKY");
       states.Add(19, "LOUISIANA, STATE CAPITAL: BATON ROUGE, SLOGAN: THE \"PELICAN STATE\", STATE FLOWER: MANGOLIA, RATIFIED: APR 30 1812,Flags/LOUISIANA");
       states.Add(20, "MAINE, STATE CAPITAL: AUGUSTA, SLOGAN: THE \"PINE TREE STATE\", STATE FLOWER: WHITE PINE CONE AND TASSEL, RATIFIED: MAR 15 1820,Flags/MAINE");

       states.Add(21, "MARYLAND, STATE CAPITAL: ANNAPOLIS, SLOGAN: THE \"OLD LINE STATE\", STATE FLOWER: BLACK-EYED SUSAN, RATIFIED: APR 28 1788,Flags/MARYLAND");
       states.Add(22, "MASSACHUSETTS, STATE CAPITAL: BOSTON, SLOGAN: THE \"BAY STATE\", STATE FLOWER: MAYFLOWER, RATIFIED: FEB 6 1788,Flags/MASSACHUSETTS");
       states.Add(23, "MICHIGAN, STATE CAPITAL: LANSING, SLOGAN: THE \"WOLVERINE STATE\", STATE FLOWER: APPLE BLOSSOM, RATIFIED: JAN 26 1837,Flags/MICHIGAN");
       states.Add(24, "MINNESOTA, STATE CAPITAL: ST. PAUL, SLOGAN: THE \"NORTH STAR STATE\", STATE FLOWER: PINK AND WHITE LADY'S SLIPPER, RATIFIED: MAY 11 1858,Flags/MINNESOTA");
       states.Add(25, "MISSISSIPPI, STATE CAPITAL: JACKSON, SLOGAN: THE \"MAGNOLIA STATE\", STATE FLOWER: MAGNOLIA, RATIFIED: DEC 10 1817,Flags/MISSISSIPPI");

       states.Add(26, "MISSOURI, STATE CAPITAL: JEFFERSON STATE, SLOGAN: THE \"SHOW-ME STATE\", STATE FLOWER: WHITE HAWTHORN, RATIFIED: AUG 10 1821,Flags/MISSOURI");
       states.Add(27, "MONTANA, STATE CAPITAL: HELENA, SLOGAN: THE \"BIG SKY COUNTRY\", STATE FLOWER: BITTEROOT, RATIFIED: NOV 8 1889,Flags/MONTANA");
       states.Add(28, "NEBRASKA, STATE CAPITAL: LINCOLN, SLOGAN: THE \"CORNHUSKER STATE\", STATE FLOWER: GOLDENROD, RATIFIED: MAR 1 1867,Flags/NEBRASKA");
       states.Add(29, "NEVADA, STATE CAPITAL: CARSON CITY, SLOGAN: THE \"SILVER STATE\", STATE FLOWER: SAGEBRUSH, RATIFIED: OCT 31 1864,Flags/NEVADA");
       states.Add(30, "NEW HAMPSHIRE, STATE CAPITAL: CONCORD, SLOGAN: THE \"GRANITE STATE\", STATE FLOWER: PURPLE LILAC, RATIFIED: JUN 21 1788,Flags/NEWHAMPSHIRE");


       states.Add(31, "NEW JERSEY, STATE CAPITAL: TRENTON, SLOGAN: THE \"GARDEN STATE\", STATE FLOWER: PURPLE VIOLET, RATIFIED: DEC 18 1787,Flags/NEWJERSEY");
       states.Add(32, "NEW MEXICO, STATE CAPITAL: SANTA FE, SLOGAN: THE \"LAND OF ENCHANTMENT\", STATE FLOWER: YUCCA, RATIFIED: JAN 6 1912,Flags/NEWMEXICO");
       states.Add(33, "NORTH CAROLINA, STATE CAPITAL: RALEIGH, SLOGAN: THE \"TARHEEL STATE\", STATE FLOWER: FLOWERING DOGWOOD, RATIFIED: NOV 21 1789,Flags/NORTHCAROLINA");
       states.Add(34, "NORTH DAKOTA, STATE CAPITAL: BISMARCK, SLOGAN: THE \"SIOUX STATE\", STATE FLOWER: PRAIRIE, RATIFIED: NOV 2 1889,Flags/NORTHDAKOTA");
       states.Add(35, "OHIO, STATE CAPITAL: COLUMBUS, SLOGAN: THE \"BUCKEYE STATE\", STATE FLOWER: SCARLET CARNATION, RATIFIED: MAR 1 1803,Flags/OHIO");

       states.Add(36, "OKLAHOMA, STATE WILDFLOWER: INDIAN BLANKET, SLOGAN: THE \"SOONER STATE\", STATE BIRD: SCISSOR-TAILED FLYCATCHER, RATIFIED: NOV 16 1907,Flags/OKLAHOMA");
       states.Add(37, "OREGON, STATE CAPITAL: SALEM, SLOGAN: THE \"BEAVER STATE\", STATE BIRD: WESTERN MEADOWLARK, RATIFIED: FEB 14 1859,Flags/OREGON");
       states.Add(38, "PENNSYLVANIA, STATE CAPITAL: HARRISBURG, SLOGAN: THE \"KEYSTONE STATE\", STATE FLOWER: MOUNTAIN LAUREL, RATIFIED: DEC 12 1787,Flags/PENNSYLVANIA");
       states.Add(39, "RHODE ISLAND, STATE CAPITAL: PROVIDENCE, SLOGAN: THE \"OCEAN STATE\", STATE FLOWER: VIOLET, RATIFIED: MAY 29 1790,Flags/RHODEISLAND");
       states.Add(40, "SOUTH CAROLINA, STATE CAPITAL: COLOMBIA, SLOGAN: THE \"PALMETTO STATE\", STATE FLOWER: YELLOW JESSAMINE, RATIFIED: MAY 23 1788,Flags/SOUTHCAROLINA");

       states.Add(41, "SOUTH DAKOTA, STATE CAPITAL: PIERRE, SLOGAN: THE \"MOUNT RUSHMORE STATE\", STATE FLOWER: PASQUE FLOWER, RATIFIED: NOV 2 1889,Flags/SOUTHDAKOTA");
       states.Add(42, "TENNESSEE, STATE CAPITAL: NASHVILLE, SLOGAN: THE \"VOLUNTEER STATE\", STATE FLOWER: IRIS, RATIFIED: JUN 1 1796,Flags/TENNESSEE");
       states.Add(43, "TEXAS, STATE CAPITAL: AUSTIN, SLOGAN: THE \"LONE STAR STATE\", STATE FLOWER: BLUEBONNET, RATIFIED: DEC 29 1845,Flags/TEXAS");
       states.Add(44, "UTAH, STATE CAPITAL: SALT LAKE CITY, SLOGAN: THE \"BEEHIVE STATE\", STATE FLOWER: SEGO LILY, RATIFIED: JAN 4 1896,Flags/UTAH");
       states.Add(45, "VERMONT, STATE CAPITAL: MONTPELIER, SLOGAN: THE \"GREEN MOUNTAIN STATE\", STATE FLOWER: RED CLOVER, RATIFIED: MAR 4 1791,Flags/VERMONT");

       states.Add(46, "VIRGINIA, STATE CAPITAL: RICHMOND, SLOGAN: THE \"OLD DOMINION STATE\", STATE FLOWER: AMERICAN DOGWOOD, RATIFIED: JUN 25 1788,Flags/VIRGINIA");
       states.Add(47, "WASHINGTON, STATE CAPITAL: OLYMPIA, SLOGAN: THE \"EVERGREEN STATE\", STATE FLOWER: PACIFIC RHODODENDRON, RATIFIED: NOV 11 1889,Flags/WASHINGTON");
       states.Add(48, "WEST VIRGINIA, STATE CAPITAL: CHARLESTON, SLOGAN: THE \"MOUNTAIN STATE\", STATE FLOWER: RHODODENDRON, RATIFIED: JUN 20 1863,Flags/WESTVIRGINIA");
       states.Add(49, "WISCONSIN, STATE CAPITAL: MADISON, SLOGAN: THE \"BADGER STATE\", STATE FLOWER: WOOD VIOLET, RATIFIED: MAY 29 1848,Flags/WISCONSIN");
       states.Add(50, "WYOMING, STATE CAPITAL: CHEYENNE, SLOGAN: THE \"EQUALITY STATE\", STATE FLOWER: INDIAN PAINTBRUSH, RATIFIED: JULY 10 1980,Flags/WYOMING");

        //Quiz dictionary
        quizOption.Add(1, "COLORADO, STATE CAPITAL: DENVER, SLOGAN: THE \"CENTENNIAL STATE\", STATE FLOWER: ROCKY MOUNTAIN COLUMBINE, RATIFIED: AUG 1 1876,Flags/Colorado");
        quizOption.Add(2, "NEW JERSEY, STATE CAPITAL: TRENTON, SLOGAN: THE \"GARDEN STATE\", STATE FLOWER: PURPLE VIOLET, RATIFIED: DEC 18 1787,Flags/NEWJERSEY");
        quizOption.Add(3, "NEW MEXICO, STATE CAPITAL: SANTA FE, SLOGAN: THE \"LAND OF ENCHANTMENT\", STATE FLOWER: YUCCA, RATIFIED: JAN 6 1912,Flags/NEWMEXICO");

        quizOption.Add(4, "DELAWARE, STATE CAPITAL: DOVER, SLOGAN: THE \"FIRST STATE\", STATE FLOWER: PEACH BLOSSOM, RATIFIED: DEC 7 1787,Flags/DELAWARE");
        quizOption.Add(5, "HAWAII, STATE CAPITAL: HONOLULU, SLOGAN: THE \"ALOHA STATE\", STATE FLOWER: HIBISCUS, RATIFIED: AUG 21 1959,Flags/HAWAII");
        quizOption.Add(6, "ALABAMA, STATE CAPITAL: MONTGOMERY, SLOGAN: THE \"HEART OF DIXIE\", STATE FLOWER: CAMELLIA, RATIFIED: DEC 14 1819,Flags/ALABAMA");

        quizOption.Add(7, "WASHINGTON, STATE CAPITAL: OLYMPIA, SLOGAN: THE \"EVERGREEN STATE\", STATE FLOWER: PACIFIC RHODODENDRON, RATIFIED: NOV 11 1889,Flags/WASHINGTON");
        Debug.Log(levelPoints);
    }

    public Dictionary<int,string> data()
    {
        return states;
    }

    public Dictionary<int, string> quizData()
    {
        return quizOption;
    }

    public void AssignPoints(int points)
    {
        levelPoints = points;

        if(points == 100)
        {
            amountOfQuestions = 10;

        }else if(points == 200)
        {
            amountOfQuestions = 25;

        }else if(points == 300)
        {
            amountOfQuestions = 50;
        }
    }

    public static void generateQuestion()
    {

        currentQuestion = Random.Range(1, 51);
        while (oldQuestion.ContainsKey(currentQuestion))
        {
            currentQuestion = Random.Range(1, 51);
        }
        oldQuestion.Add(currentQuestion, "Here");
        currentMainQuestion += 1;
        if (currentQuizQuestion < 7)
            currentQuizQuestion += 1;
    }
}

