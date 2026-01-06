namespace RestSharp.Tests.Serializers.Xml.SampleClasses;

public class Category {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Category> Subcategories { get; set; } = new();
}

public class CategoryRoot {
    public List<Category> Categories { get; set; } = new();
}

// This class derives from List<Category> and will trigger HandleListDerivative
public class CategoryList : List<Category> {
    public int TotalCount { get; set; }
}
