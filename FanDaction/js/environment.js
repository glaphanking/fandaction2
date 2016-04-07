var fandAppModule = "fandApp"; //
var hostname = location.protocol.indexOf('http') == 0 ? location.hostname : 'localhost';
var dataUri = "http://" + hostname + ":8080/api/"; // data service
var systemUri = "http://" + hostname + ":8085/api/"; // system service (PDF, printing, etc..)