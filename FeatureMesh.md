# Test Specifications for Feature Publication


## Manual Input Through GUI:

  ### Test Case 1: Successful Submission  
    Given valid data entered manually through the GUI,
    When a POST request is sent to the API endpoint with the entered data,
    Then the API should respond with a success status code (200 OK) and the data should be stored correctly.
    
  ### Test Case 2: Invalid Input
    Given invalid data entered manually through the GUI,
    When a POST request is sent to the API endpoint with the invalid data,
    Then the API should respond with an error status code (400 Bad Request) and provide an informative error message.

  ### Test Case 3: Security Measures
    Given an attempt to directly send a POST request to the API endpoint without using the GUI,
    When the request is made,
    Then the API should respond with an error status code indicating unauthorized access (401 Unauthorized or 403 Forbidden).
    
## Upload Input:

  ### Test Case 1: Successful Upload
    Given a valid data file uploaded through the API,
    When a POST request is sent to the API endpoint with the uploaded file,
    Then the API should respond with a success status code (200 OK) and the data should be stored correctly.
    
  ### Test Case 2: Invalid File Format
    Given an invalid data file format uploaded through the API,
    When a POST request is sent to the API endpoint with the invalid file,
    Then the API should respond with an error status code (400 Bad Request) and provide an informative error message.
    
  ### Test Case 3: Large File Handling
    Given a large data file uploaded through the API,
    When a POST request is sent to the API endpoint with the large file,
    Then the API should respond with an error status code indicating that the file is too large to process (e.g., 413 Request Entity Too Large).


## Validating Insertion of Feature into database
- **Objective:** Ensure that the `CreateAsync` method in the `MongoDBService` class correctly inserts a new feature into the MongoDB collection.
- **Inputs:** MongoDB mock settings, mock feature collection, mock service, feature object
- **Expected Output:** Successful insertion into mongodb.

```csharp
[Test]
public async Task CreateAsync_ShouldInsertFeature()
{
    // Arrange
    var mockSettings = new Mock<IOptions<MongoDBSettings>>();
    var mockCollection = new Mock<IMongoCollection<Feature>>();
    var service = new MongoDBService(mockSettings.Object);
    var feature = new Feature {  };
 
    // Act
    await service.CreateAsync(feature);
 
    // Assert
    mockCollection.Verify(m => m.InsertOneAsync(feature, It.IsAny<InsertOneOptions>(), It.IsAny<CancellationToken>()), Times.Once);

}
```
