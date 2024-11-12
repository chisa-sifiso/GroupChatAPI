<h1 align="center">Module Chat Backend</h1>
<p align="center">
  A SignalR-based backend for real-time group chats, enabling mentors and mentees to interact within a specific module (e.g., <strong>ppa015D</strong>).
</p>

<hr />

<h2>🚀 Features</h2>
<ul>
  <li>Real-time group messaging using SignalR.</li>
  <li>Group-based file sharing (supports images, documents, etc.).</li>
  <li>Dynamic group joining based on module codes.</li>
  <li>Role-based integration for Mentors and Mentees.</li>
</ul>

<h2>📁 Project Structure</h2>
<pre>
├── Hubs
│   ├── CommunicationHub.cs
│   ├── CustomUserIdProvider.cs
├── Program.cs
├── appsettings.json
├── Pages
│   └── Error.cshtml
├── wwwroot
│   ├── css
│   ├── js
</pre>

<h2>🛠️ Tech Stack</h2>
<ul>
  <li><strong>Framework:</strong> ASP.NET Core</li>
  <li><strong>Real-Time Communication:</strong> SignalR</li>
  <li><strong>Languages:</strong> C#, JavaScript</li>
  <li><strong>Server:</strong> Kestrel</li>
</ul>

<h2>⚙️ Installation</h2>
<ol>
  <li>Clone the repository:
  </li>
  <li>Navigate to the project directory:
    <pre><code>cd ModuleChatBackend</code></pre>
  </li>
  <li>Install dependencies:
    <pre><code>dotnet restore</code></pre>
  </li>
  <li>Run the application:
    <pre><code>dotnet run</code></pre>
  </li>
</ol>

<h2>🔑 API Endpoints</h2>
<table>
  <thead>
    <tr>
      <th>Endpoint</th>
      <th>Method</th>
      <th>Description</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>/communicationHub</td>
      <td>WebSocket</td>
      <td>SignalR hub for real-time communication.</td>
    </tr>
  </tbody>
</table>

<h2>👨‍💻 Contributors</h2>
<ul>
  <li><strong>Your Name:</strong> Backend Development</li>
</ul>

<h2>📄 License</h2>
<p>This project is licensed under the <a href="LICENSE">MIT License</a>.</p>

