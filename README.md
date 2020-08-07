# Music-Metadata-Structure-Setup
Simple application that applies directory structure to music metadata.<br/>
<a href="https://github.com/ShortDevelopment/Music-Metadata-Structure-Setup/releases/tag/v1.0">Download</a>
# Example
```
├─── [Folder] Artist or Series Name
│     ├─── [Folder] Album Name
|     |     ├─── [File] Track1.mp3
|     |     ├─── [File] Track2.mp3
|     |     └─── [File] *.mp3
|     └─── [Folder] Next Album
|           ├─── [File] Track1.mp3
|           ├─── [File] Track2.mp3
|           └─── [File] *.mp3    
└─── [Folder] Example
      └─── [Folder] Test
            ├─── [File] Track1.mp3
            └─── [File] [...].mp3
```
### Output
`Path > Example > Test`
<table>
  <tr>
    <td>Name</td><td>Track Number</td><td>Title</td><td>Artist</td><td>Album</td>
  </tr>
  <tr>
    <td>Track1.mp3</td><td>1</td><td>Track1</td><td>Example</td><td>Test</td>
  </td>
  <tr>
    <td>[...].mp3</td><td>2</td><td>[...]</td><td>Example</td><td>Test</td>
  </td>
</table>
