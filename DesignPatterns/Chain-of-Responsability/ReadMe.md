<p>The Chain of Responsibility Pattern is a behavioral design pattern where a request is passed through a chain of handlers. Each handler decides either to process the request or to pass it along the chain to the next handler.</p>
<br>
<p>For this illustration, we will employ a discount calculator.</p>
<br>
<p><strong>Follow the commit history to understand the problem and see to implementation of the Strategy Pattern </strong></p>

<!-- ## Examples of Using the Chain of Responsibility Pattern -->

<p>The Chain of Responsibility pattern is beneficial in situations where you have a chain of handlers that can process a request sequentially. In addition to a discount calculator, here are some scenarios where the Chain of Responsibility pattern can be applied:</p>

<ol>
  <li>
    <strong>Data Validation:</strong>
    <p>Each handler can be responsible for validating a specific aspect of the data, such as format, length, or custom validations.</p>
  </li>

  <li>
    <strong>Document Processing:</strong>
    <p>In a document processing system, different handlers can be responsible for extracting information, applying formatting, and checking validity.</p>
  </li>

  <li>
    <strong>User Authentication:</strong>
    <p>Each handler can check a specific authentication criterion, such as a password, biometric authentication, or two-factor authentication.</p>
  </li>

  <li>
    <strong>API Processing Pipeline:</strong>
    <p>An API can have a chain of handlers to process a request, including authentication, authorization, input validation, and data handling.</p>
  </li>

  <li>
    <strong>Error Logging:</strong>
    <p>Each handler can be responsible for handling different types of errors, logging relevant information, or sending alerts.</p>
  </li>

  <li>
    <strong>Dynamic Workflow:</strong>
    <p>In a workflow system, each step of the process can be a handler in the chain, allowing easy extension or modification of the flow.</p>
  </li>

  <li>
    <strong>Notification System:</strong>
    <p>Each handler can determine whether a notification should be sent based on specific criteria, such as the type of event or priority.</p>
  </li>

  <li>
    <strong>User Interface Event Handling:</strong>
    <p>In building user interfaces, different handlers can deal with input events, such as button clicks, touches, or keyboard shortcuts.</p>
  </li>

  <li>
    <strong>Filtering in Search Systems:</strong>
    <p>In a search system, different handlers can apply filters based on specific criteria, such as relevance, date, or category.</p>
  </li>

  <li>
    <strong>Order Processing in E-commerce:</strong>
    <p>Each handler can be responsible for different stages of processing an order, such as inventory verification, final price calculation, and applying discounts.</p>
  </li>
</ol>

<p>The Chain of Responsibility pattern is versatile and can be applied in many scenarios where responsibility can be dynamically divided among multiple handlers.</p>
