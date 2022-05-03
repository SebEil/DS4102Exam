import axios from "axios";
import { ref } from 'vue'

const soldierService = (function(){

    const soldiers = ref([]);

    const soldierControllerUrl = "https://localhost:7203/Soldier";

    const imageUploadControllerUrl = "https://localhost:7203/ImageUpload/PostImage";

    ( async ()=>{
        const request = await axios.get(soldierControllerUrl);
        soldiers.value = request.data;
    })()

    const getAllSoldiers = () => soldiers;

    const getById = async (soldierId) => {
        const request = await axios.get(`https://localhost:7203/soldier/${soldierId}`)
        return request.data;
    }

    const putSoldier = async (editedSoldier) => {
        await axios.put("https://localhost:7203/soldier", editedSoldier)
        
        const temporarySoldierArray = JSON.parse( JSON.stringify( soldiers.value ))

        const index = temporarySoldierArray.findIndex( soldier => parseInt( soldier.id ) === parseInt( editedSoldier.id ) );

        soldiers.value[index].soldierName = editedSoldier.soldierName;
        soldiers.value[index].bloodtype = editedSoldier.bloodtype;
        soldiers.value[index].height = editedSoldier.height;
        soldiers.value[index].image = editedSoldier.image;
        soldiers.value[index].isOnMission = editedSoldier.isOnMission;
    }

    const postSoldier = ( newSoldier, image ) => {
        axios.post( soldierControllerUrl, newSoldier )
        
        axios({ 
            method: "POST",
            url: imageUploadControllerUrl,
            data: image,
            config: { header: { "Content-Type": "multipart/form-data" } }
        });
        
        soldiers.value.push(newSoldier);
    }

    const deleteSoldier = async ( soldierToDelete ) => {
        await axios.delete(`https://localhost:7203/soldier/${soldierToDelete}`)
        soldiers.value.pop(soldierToDelete)
        
    }

    return {
        getAllSoldiers,
        getById,
        deleteSoldier,
        postSoldier,
        putSoldier
    }
}())

export default soldierService;