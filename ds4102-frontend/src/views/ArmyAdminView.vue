<template>
    <section>
        <h2>Army admin page</h2>
        <h3>Search here</h3>
        <label>Id</label>
        <input v-model="missionId" type="text">
        <input @click="getMission" type="button" value="Get"><br>
        <label>Name</label>
        <input v-model="missionName" type="text"><br>
        <label>Location</label>
        <input v-model="missionLocation" type="text"><br>
        <label>Soldier deployed</label>
        <input v-model="soldiersDeployed" type="text"><br>
        <input @click="changeMission" type="button" value="Save changes">
        <input @click="postMission" type="button" value="Add">
        <input @click="deleteMission" type="button" value="Delete">
        <missions-list></missions-list>


    </section>
</template>


<script>
import MissionsList from "../components/missions/MissionsList.vue"
import missionService from "../services/missionService.js"
import {reactive, toRefs} from 'vue'


export default {
  setup(){
       
       const missionForm = reactive({
            missionId: "",
            missionName: "",
            missionLocation: "",
            soldiersDeployed: 1
        });

        const missionFormNew = reactive({
            missionName: "",
            missionLocation: "",
            soldiersDeployed: 1
        });

        const getMission = async () => {
            const mission = await missionService.getById(missionForm.missionId);
            missionForm.missionName = mission.missionName;
            missionForm.missionLocation = mission.missionLocation;
            missionForm.soldiersDeployed = mission.soldiersDeployed;           
        }

        const changeMission = async () => {

            const editedMission = {
                missionId: parseInt( missionForm.missionId ),
                missionName: missionForm.missionName,
                missionLocation: missionForm.missionLocation,
                soldiersDeployed: parseInt( missionForm.soldiersDeployed)
            }

            missionService.putMission( editedMission );
        }

        const postMission = () => {

            const newMission = {
<<<<<<< HEAD
                missionId: missionForm.missionId,
                missionName: missionForm.missionName,
                missionLocation: missionForm.missionLocation,
                soldiersDeployed: missionForm.soldiersDeployed
=======
                missionId: missionFormNew.missionId,
                missionName: missionFormNew.missionName,
                missionLocation: missionFormNew.missionLocation,
                soldiersDeployed: missionFormNew.soldiersDeployed
>>>>>>> 6fb6d8cc939dd4d6183ce70d2adfcad9a0911fe1
            };

            missionService.postMission ( newMission );
        }

        

      return{
          getMission,
          changeMission,
          postMission,
          ...toRefs( missionForm )
      }
  },
  components: { 
      MissionsList 
    },
  
}
</script>
