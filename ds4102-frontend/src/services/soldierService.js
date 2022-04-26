import axios from "axios";
import { ref } from 'vue'

const soldierService = (function(){

    const soldiers = ref([]);

    const soldierControllerUrl = "https://localhost:7203/Soldier";
    //const imageUploadControllerUrl ="https://localhost:7203/imageUpload/postImage"

    ( async ()=> {
        const request = await axios.get(soldierControllerUrl);
        soldiers.value = request.data;
    })()

    const getAll = () => soldiers;

    /*const postSoldier = ( newSoldier, image ) =>

        axios.post(soldierControllerUrl, newSoldier);

        axios({
            method: "POST",
            url: imageUploadControllerUrl,
            data: image,
            config: { header: { "Content-Type": "multipart/form-data" } }
        });

    soldiers.value.push(newSoldier) */

    return {
        getAll,
        //postSoldier
    }
}())

export default soldierService;