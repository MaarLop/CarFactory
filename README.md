# Car Factory API

This API provides functionalities for managing sales of cars through a distribution network. It utilizes a MediatR-based architecture for handling requests and responses.

**Features:**

* Create a Sale: Create a new sale record for a car associated with a distribution center.
* Get Total Volume: Retrieve the total volume of cars sold across all distribution centers.
* Get Total Volume by Distribution ID: Retrieve the total volume of cars sold for a specific distribution center.
* Get Percent of Models Sold: Get the percentage of sales for each car model.

**API Endpoints:**

* `/api/sales` (POST): Creates a new sale.
* `/api/sales/totalVolumes` (GET): Retrieves the total volume of cars sold.
* `/api/sales/totalVolumesByDistributionId?distributionId={distributionId}` (GET): Retrieves the total volume of cars sold for a specific distribution center.
* `/api/sales/modelPercent` (GET): Retrieves the percentage of sales for each car model.

**Request and Response Formats:**

The API primarily uses JSON for request and response data. 

**Authentication:**

[Describe the authentication mechanism used by the API, if any. If not applicable, mention that no authentication is required.]

**Error Handling:**

The API follows a standard HTTP status code convention for error responses:

* 200 OK: Successful request.
* 400 Bad Request: Invalid request data or parameters.
* 401 Unauthorized: Access denied due to missing or invalid authentication credentials (if applicable). (TODO)
* 404 Not Found: Resource not found. (TODO)
* 500 Internal Server Error: Unexpected error on the server side.

**Additional Notes:**

* For detailed information about the request and response data formats for each endpoint, refer to the API documentation for the specific feature or functionality.
* Consider including links to any relevant documentation or code repositories.

**Example Usage:**

**Creating a Sale:**

```json
POST /api/sales
Content-Type: application/json

{
  "carId": 1,
  "distributionCenterId": 2
}
```
**Response:**

```json
HTTP/1.1 201 Created
Content-Type: application/json

{
  "id": 1,
  "carId": 1,
  "distributionCenterId": 2,
  "createdAt": "2023-01-18T12:33:22Z"
}
```
**Getting Total Volume:**
```json
GET /api/sales/totalVolumes
Response (Successful):
```

```json
HTTP/1.1 200 OK
Content-Type: application/json

{
  "totalVolume": 100
}
```

**Getting Total Volume by Distribution ID:**
```json
GET /api/sales/totalVolumesByDistributionId?distributionId=1
Response (Successful):
```
```json
HTTP/1.1 200 OK
Content-Type: application/json

{
  "totalVolume": 19474,
  "distributionCenterId": 1
}
```
**Getting Percent of Models Sold:**
```json
GET /api/sales/modelPercent
Response (Successful):
```
```json
HTTP/1.1 200 OK
Content-Type: application/json

{
  "Sport": 25,
  "Offroad": 75
...
}
```
