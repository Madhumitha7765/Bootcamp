# API Documentation

## Students Endpoints

### Get All Students
- **Method:** GET
- **Endpoint:** `/api/v1/students`
- **Response:**
  - Status Code: 200 OK
  - Body: Array of JSON objects, each representing a student.

### Get Student by ID
- **Method:** GET
- **Endpoint:** `/api/v1/students/{student_id}`
- **Response:**
  - Status Code: 200 OK
  - Body: JSON object representing the specified student.
  - Status Code: 404 Not Found if the student with the given ID is not found.

### Create Student
- **Method:** POST
- **Endpoint:** `/api/v1/students`
- **Request Body:**
  ```json
  {
    "name": "John Doe",
    "age": 20,
    "grade": "A"
  }
  ```
- **Response:**
  - Status Code: 201 Created
  - Body: JSON object representing the newly created student.

### Update Student
- **Method:** PUT
- **Endpoint:** `/api/v1/students/{student_id}`
- **Request Body:**
  ```json
  {
    "name": "Updated Name",
    "age": 21,
    "grade": "B"
  }
  ```
- **Response:**
  - Status Code: 200 OK
  - Body: JSON object representing the updated student.
  - Status Code: 404 Not Found if the student with the given ID is not found.

### Delete Student
- **Method:** DELETE
- **Endpoint:** `/api/v1/students/{student_id}`
- **Response:**
  - Status Code: 204 No Content
  - No response body.

## Courses Endpoints

### Get All Courses
- **Method:** GET
- **Endpoint:** `/api/v1/courses`
- **Response:**
  - Status Code: 200 OK
  - Body: Array of JSON objects, each representing a course.

### Get Course by ID
- **Method:** GET
- **Endpoint:** `/api/v1/courses/{course_id}`
- **Response:**
  - Status Code: 200 OK
  - Body: JSON object representing the specified course.
  - Status Code: 404 Not Found if the course with the given ID is not found.

### Create Course
- **Method:** POST
- **Endpoint:** `/api/v1/courses`
- **Request Body:**
  ```json
  {
    "name": "Introduction to Programming",
    "credits": 3
  }
  ```
- **Response:**
  - Status Code: 201 Created
  - Body: JSON object representing the newly created course.

### Update Course
- **Method:** PUT
- **Endpoint:** `/api/v1/courses/{course_id}`
- **Request Body:**
  ```json
  {
    "name": "Updated Course Name",
    "credits": 4
  }
  ```
- **Response:**
  - Status Code: 200 OK
  - Body: JSON object representing the updated course.
  - Status Code: 404 Not Found if the course with the given ID is not found.

### Delete Course
- **Method:** DELETE
- **Endpoint:** `/api/v1/courses/{course_id}`
- **Response:**
  - Status Code: 204 No Content
  - No response body.

## Linking Students to Courses

### Enroll Student in a Course
- **Method:** POST
- **Endpoint:** `/api/v1/courses/{course_id}/enroll`
- **Request Body:**
  ```json
  {
    "studentId": 123
  }
  ```
- **Response:**
  - Status Code: 201 Created
  - Body: JSON object indicating successful enrollment.

### Get Courses for a Student
- **Method:** GET
- **Endpoint:** `/api/v1/students/{student_id}/courses`
- **Response:**
  - Status Code: 200 OK
  - Body: Array of JSON objects, each representing a course the student is enrolled in.
  - Status Code: 404 Not Found if the student with the given ID is not found.

### Get Students in a Course
- **Method:** GET
- **Endpoint:** `/api/v1/courses/{course_id}/students`
- **Response:**
  - Status Code: 200 OK
  - Body: Array of JSON objects, each representing a student enrolled in the course.
  - Status Code: 404 Not Found if the course with the given ID is not found.

### Remove Student from a Course
- **Method:** DELETE
- **Endpoint:** `/api/v1/courses/{course_id}/enroll/{student_id}`
- **Response:**
  - Status Code: 204 No Content
  - No response body.
