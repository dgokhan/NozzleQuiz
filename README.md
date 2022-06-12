# NozzleQuiz
NozzleQuiz with Onion Architecture, MediatR &amp; CQRS

![ss2.png](https://github.com/dgokhan/NozzleQuiz/blob/main/img/nozzleonionarch.png?raw=true)

* OAuthControllerController -> Gönderilen request'ler 'https://apidemo.nozzlesoft.com/' adresine gönderilir ve response değerleri gösterilir.
* InventoryManagementController -> Gönderilen request'leri 'https://apidemo.nozzlesoft.com/api' adresine gönderir ve response değerleri gösterilir.
* DatabaseOperationsController -> Gönderilen request'ler ilk önce 'https://apidemo.nozzlesoft.com/api' servislerine gönderilir ve gelen response değerlerini veritabanına kaydeder / kaydedilen verileri db üzerinden görüntülenir.

# * Example | SearchMaterialCategoryAsync Request 

![ss2.png](https://github.com/dgokhan/NozzleQuiz/blob/main/img/req.png?raw=true)

# * Example Response;

![ss2.png](https://github.com/dgokhan/NozzleQuiz/blob/main/img/response.png?raw=true)

&&

![ss2.png](https://github.com/dgokhan/NozzleQuiz/blob/main/img/responsedb.png?raw=true)
