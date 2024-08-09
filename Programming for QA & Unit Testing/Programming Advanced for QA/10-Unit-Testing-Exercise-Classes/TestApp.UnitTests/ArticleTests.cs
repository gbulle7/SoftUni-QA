using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    // TODO: write the setup method
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = { "Article Content Author",
                           "Article2 Content2 Author2",
                           "Article3 Content3 Author3"
                         };

        // Act
        Article result = _article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        string[] input = { "ZArticle Content Author",
                           "Article2 Content2 Author2",
                           "CArticle3 Content3 Author3"
                         };

        string expected = $"Article2 - Content2: Author2{Environment.NewLine}" +
            $"CArticle3 - Content3: Author3{Environment.NewLine}" +
            $"ZArticle - Content: Author";

        // Act
        Article resultArticle = _article.AddArticles(input);
        string result = resultArticle.GetArticleList(resultArticle, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] input = { "ZArticle Content Author",
                           "Article2 Content2 Author2",
                           "CArticle3 Content3 Author3"
                         };

        string expected = string.Empty;

        // Act
        Article resultArticle = _article.AddArticles(input);
        string result = resultArticle.GetArticleList(resultArticle, "Title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
