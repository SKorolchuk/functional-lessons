module BookSamples

open System.IO

type 'T option =
| None
| Some of 'T

let http (url: string) =
    let req = System.Net.WebRequest.Create(url)
    let resp = req.GetResponse()
    let stream = resp.GetResponseStream()
    let reader = new StreamReader(stream)
    let html = reader.ReadToEnd()
    resp.Close()
    html

let fetch url =
    try Some (http url)
    with :? System.Net.WebException -> None