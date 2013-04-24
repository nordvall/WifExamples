REM Make root certificate trusted
certutil -addstore Root "ClaimsServices root.cer"

REM Configure certificate for TokenService
certutil -importpfx -p P@ssw0rd DummySTS.pfx NoChain,NoRoot
netsh http add sslcert ipport=0.0.0.0:44500 certhash=18145fb6b5d96b3cc34ec7599f12172bb93c68ef appid={214124cd-d05b-4309-9af9-9caa44b2b74a}


REM Configure certificate for ClaimsServices
certutil -importpfx -p P@ssw0rd ClaimsService.pfx NoChain,NoRoot 
netsh http add sslcert ipport=0.0.0.0:44535 certhash=a2028f8e7f7b082cd35e81fd0ca0b70b04651abf appid={214124cd-d05b-4309-9af9-9caa44b2b74a}
netsh http add sslcert ipport=0.0.0.0:44540 certhash=a2028f8e7f7b082cd35e81fd0ca0b70b04651abf appid={214124cd-d05b-4309-9af9-9caa44b2b74a}
netsh http add sslcert ipport=0.0.0.0:44545 certhash=a2028f8e7f7b082cd35e81fd0ca0b70b04651abf appid={214124cd-d05b-4309-9af9-9caa44b2b74a}

