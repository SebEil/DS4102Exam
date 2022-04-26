import axios from "axios";
import { ref } from 'vue'

const soldierService = (function(){

    const soldiers = ref([]);

    const soldierControllerUrl = "https://localhost:7203/soldier";
    //const imageUploadControllerUrl ="https://localhost:7203/imageUpload/postImage"

    ( async ()=>{
        const request = await axios.get(soldierControllerUrl);
        soldiers.value = request.data;
    })()

    const getAllSoldiers = () => soldiers;

    const postSoldier = ( newSoldier ) =>
    
    soldiers.value.push(newSoldier)

    return {
        getAllSoldiers,
        postSoldier
    }

    /*const postSoldier = ( newSoldier, image ) =>

        axios.post(soldierControllerUrl, newSoldier);

        axios({
            method: "POST",
            url: imageUploadControllerUrl,
            data: image,
            config: { header: { "Content-Type": "multipart/form-data" } }
        });

    soldiers.value.push(newSoldier) */
}())

export default soldierService;