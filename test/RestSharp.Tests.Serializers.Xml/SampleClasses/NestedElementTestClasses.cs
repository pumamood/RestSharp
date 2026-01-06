namespace RestSharp.Tests.Serializers.Xml.SampleClasses;

// Test classes for nested element bugs

public class Category {
    public int Id { get; set; }
    public List<Category> Subcategories { get; set; }
}

public class CategoryContainer {
    public List<Category> Categories { get; set; } = new();
}

public class PrestashopResponse {
    public CategoryContainer Categories { get; set; } = new();
}

public class CategoryWithAssociations {
    public int Id { get; set; }
    public CategoryAssociations Associations { get; set; }
}

public class CategoryAssociations {
    public List<Category> Categories { get; set; }
}

public class PrestashopCategoryResponse {
    public List<CategoryWithAssociations> Categories { get; set; } = new();
}
