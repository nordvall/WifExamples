REM Remove trusted root certificate
certutil -delstore Root 9500a27eb45202fd7a4aafbc6fbd87a4a7441080

REM Remove TokenService cert and config
certutil -delstore My 18145fb6b5d96b3cc34ec7599f12172bb93c68ef
netsh http delete sslcert ipport=0.0.0.0:44500 


REM Remove ClaimsServices cert and config
certutil -delstore My a2028f8e7f7b082cd35e81fd0ca0b70b04651abf
netsh http delete sslcert ipport=0.0.0.0:44535 
netsh http delete sslcert ipport=0.0.0.0:44540 
netsh http delete sslcert ipport=0.0.0.0:44545 

